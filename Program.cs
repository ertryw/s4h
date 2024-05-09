using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using s4h.Models;
using s4h.Repositories;
using s4h.Services;
using s4h.Validators;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddDbContext<S4hHotelonlineContext>(e => e.UseSqlServer(builder.Configuration.GetConnectionString("S4H")));
builder.Services.AddScoped<IRoomRepository, RoomRepositiory>();
builder.Services.AddScoped<ILocalsService, LocalsService>();
builder.Services.AddValidatorsFromAssemblyContaining<RomRoomValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
