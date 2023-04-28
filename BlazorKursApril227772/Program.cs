using BlazorKursApril227772.Data;
using BlazorKursApril227772.Models;
using BlazorKursApril227772.Pages.Modul4;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<NachrichtenVM>();
builder.Services.AddHttpClient();

//  => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;
//  Initial Catalog=Northwind;Integrated Security=True"); kommt aus dbcontext scaffold

builder.Services.AddDbContext<NorthwindContext>(o =>
o.UseSqlServer(builder.Configuration.GetConnectionString("Northwind")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
