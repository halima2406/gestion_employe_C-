using Data;
using GesEmpAspNet.Services;
using GesEmpAspNet.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GesEmpDbContext>();
builder.Services.AddScoped<IDepartementService, DepartementService>();
builder.Services.AddScoped<IEmployeService, EmployeService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Departement}/{action=Index}/{id?}");

app.Run();
