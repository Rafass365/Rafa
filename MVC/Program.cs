using MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. - Add services to the container. Inyector dependencias = Contenedor
builder.Services.AddControllersWithViews();

//
// Agregado servicio TestB
builder.Services.AddScoped<ITest, TestB>();

// Agregar servicio repositorio
builder.Services.AddScoped<IConversorRepositorio, ConversorRepositorio>();


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
