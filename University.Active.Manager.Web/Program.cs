using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Storage;
using University.Active.Manager.Web.Configuration;
using EventFakeRepository = University.Active.Manager.Storage.EventFakeRepository;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase();

builder.Services.AddRazorPages();
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IEventRepository, EventRepository>();
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}).CreateMapper());
var app = builder.Build();
app.Map("/", async context =>
{
    //может вернуть Null
    var eventService = context.RequestServices.GetService<IEventService>();
    if (eventService != null) 
        await context.Response.WriteAsJsonAsync(await eventService.GetAllActiveEvents());
});
app.UseStaticFiles();

app.MapRazorPages();

app.Run();