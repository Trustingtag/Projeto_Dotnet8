using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Projeto_Dotnet8.Data;
using Microsoft.Extensions.DependencyInjection;
using Projeto_Dotnet8.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers();

string MySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BancoContext>(opt =>
{
    opt.UseMySql(MySqlConnection, ServerVersion.AutoDetect(MySqlConnection));
});

builder.Services.AddScoped<IcomputadorRepository, ComputadorRepository>();
builder.Services.AddScoped<ISalaRepository, SalaRepository>();

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
    pattern: "{controller=Principal}/{action=Login}/{id?}");

app.Run();
