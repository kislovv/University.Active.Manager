using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Storage;
using University.Active.Manager.Web.Configuration;
using Contract =  University.Active.Manager.Contracts;


var builder = WebApplication.CreateBuilder(args);

//Добавление БД (метод расширения в проекте Storage)
builder.Services.AddDatabase();

//Поддержка Razor pages
builder.Services.AddRazorPages();

//Примеры сервисов (Event и репозитория)
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IEventRepository, EventRepository>();
builder.Services.AddTransient<ISubjectRepository, SubjectRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Пример добавение Automapper с кастомным профилем
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}).CreateMapper());


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

app.MapPost("/addSubject", async (Contract.University.Subject subject, ISubjectRepository subjectRepository, IMapper mapper) =>
{
    var result = await subjectRepository.AddSubject(mapper.Map<Subject>(subject));
    
    return Results.Ok(mapper.Map<Contract.University.Subject>(result));
});

//Подключение в цепочку статических файлов
app.UseStaticFiles();

//Подключение анализ на сопоставление запроса с  RazorPage 
app.MapRazorPages();

//Запуск приложения для начала прослушивания узла на запросы
app.Run();