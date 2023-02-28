using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;
using University.Active.Manager.Storage;
using University.Active.Manager.Web.Configuration;


var builder = WebApplication.CreateBuilder(args);
/*
builder.Services.AddDatabase(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["App:DbConnectionString"]);
    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
*/
builder.Services.AddRazorPages();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<ContractProfile>();
}));
var app = builder.Build();
app.Map("/", async context =>
{
    //может вернуть Null
    var eventService = context.RequestServices.GetService<IEventService>();
    
    eventService?.RegisterNewEvent(new Event());
    await context.Response.WriteAsync($"Hello World!");
});
app.UseStaticFiles();

app.MapRazorPages();

app.Run();