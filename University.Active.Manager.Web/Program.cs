using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Services;
using University.Active.Manager.Storage.PgSql;
using University.Active.Manager.Utilities;
using University.Active.Manager.Web.Configuration;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtOptions:Issuer"],
        ValidAudience = builder.Configuration["JwtOptions:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtOptions:Key"]))
    };
});


//Добавление БД (метод расширения в проекте Storage)
builder.Services.AddDatabase(builder.Configuration);

//Поддержка Razor pages
builder.Services.AddRazorPages();

//Примеры сервисов (Event и репозитория)
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddSingleton<ITokenService, TokenService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Пример добавение Automapper с кастомным профилем
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}).CreateMapper());

builder.Services.Configure<HashOptions>(builder.Configuration.GetSection("Hash"));
builder.Services.AddSingleton<HashHelper>();
builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("JwtOptions"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseStatusCodePages(context => {
    var response = context.HttpContext.Response;

    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        response.Redirect("/Account/Login");
    }

    return Task.CompletedTask;
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Пример метода Map без указания метода
app.Map("/", (IConfiguration appConfig) => $"{string.Join("\r\n",appConfig.AsEnumerable().Select(x=> $"{x.Key} : {x.Value} "))} ");

//Подключение анализ на сопоставление запроса с  RazorPage 
app.MapRazorPages();

//Запуск приложения для начала прослушивания узла на запросы
app.Run();