using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UT_02_Ejercicio_01.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RentalCar>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UT_02_Ejercicio_01Context") ?? throw new InvalidOperationException("Connection string 'UT_02_Ejercicio_01Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Cars}/{action=Index}/{id?}");

app.Run();
