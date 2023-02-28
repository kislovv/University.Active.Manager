using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Web.Configuration;
using EventRepository = University.Active.Manager.Storage.EventRepository;


var builder = WebApplication.CreateBuilder(args);
/*
builder.Services.AddDatabase(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["App:DbConnectionString"]);
    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
*/
builder.Services.AddRazorPages();
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<IEventRepository, EventRepository>();
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}));
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