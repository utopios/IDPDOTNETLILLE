using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CashRegistryEntityFrameWork.Tools;
using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using CorrectionCaisseEnregistreuseAspNetCore.Services;
using CorrectionCaisseEnregistreuseAspNetCore.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddScoped<BaseRepository<Product>, ProductRepository>();
//builder.Services.AddScoped<BaseRepository<Order>, OrderRepository>();
//builder.Services.AddScoped<BaseRepository<CashRegistryUser>, CashRegistryUserRepository>();
//builder.Services.AddScoped<ICart, CartSessionService>();
//builder.Services.AddScoped<ILogin, LoginSessionService>();
builder.Services.AddAllServices();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CashRegistry}/{action=Index}/{id?}");

app.Run();
