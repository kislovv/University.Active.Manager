using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Storage.PgSql;
using University.Active.Manager.Utilities;
using University.Active.Manager.Web.Configuration;


var builder = WebApplication.CreateBuilder(args);

//Добавление БД (метод расширения в проекте Storage)
builder.Services.AddDatabase(builder.Configuration);

//Поддержка Razor pages
builder.Services.AddRazorPages();

//Примеры сервисов (Event и репозитория)
builder.Services.AddTransient<IEventService, EventService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Пример добавение Automapper с кастомным профилем
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}).CreateMapper());

builder.Services.Configure<HashOptions>(builder.Configuration.GetSection("Hash"));
builder.Services.AddSingleton<HashHelper>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Пример метода Map без указания метода
app.Map("/", async context =>
{
    //может вернуть Null
    var eventService = context.RequestServices.GetService<IEventService>();
    if (eventService != null) 
        await context.Response.WriteAsJsonAsync(await eventService.GetAllActiveEvents());
});

app.MapPost("/addSubject", async (Subject subject, ISubjectRepository subjectRepository, IMapper mapper) =>
{
    var result = await subjectRepository.AddSubject(subject);
    
    return Results.Ok(result);
});

app.MapPost("/addInstitute",
    async (Institute institute, IInstituteRepository instituteRepository, IMapper mapper) =>
    {
        var result = await instituteRepository.AddInstitute(mapper.Map<Institute>(institute));
        
        return Results.Ok(result);
    });

//Подключение в цепочку статических файлов
app.UseStaticFiles();

//Подключение анализ на сопоставление запроса с  RazorPage 
app.MapRazorPages();

//Запуск приложения для начала прослушивания узла на запросы
app.Run();