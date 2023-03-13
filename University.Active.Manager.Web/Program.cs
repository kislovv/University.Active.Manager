using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Storage;
using University.Active.Manager.Web.Configuration;


var builder = WebApplication.CreateBuilder(args);

//Добавление БД (метод расширения в проекте Storage)
builder.Services.AddDatabase();

//Поддержка Razor pages
builder.Services.AddRazorPages();

//Примеры сервисов (Event и репозитория)
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IEventRepository, EventRepository>();

//Пример добавение Automapper с кастомным профилем
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}).CreateMapper());


var app = builder.Build();

//Пример метода Map без указания метода
app.Map("/", async context =>
{
    //может вернуть Null
    var eventService = context.RequestServices.GetService<IEventService>();
    if (eventService != null) 
        await context.Response.WriteAsJsonAsync(await eventService.GetAllActiveEvents());
});

//Подключение в цепочку статических файлов
app.UseStaticFiles();

//Подключение анализ на сопоставление запроса с  RazorPage 
app.MapRazorPages();

//Запуск приложения для начала прослушивания узла на запросы
app.Run();