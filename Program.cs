using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ContextoUser>(options =>
    options.UseNpgsql("Host=localhost;Port=5433;Database=Projeto-Fatec;Username=postgres;Password=Teste01;"));

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
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();