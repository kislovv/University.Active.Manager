using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Storage;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["App:DbConnectionString"]);
    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddRazorPages();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();

app.MapRazorPages();

app.Run();