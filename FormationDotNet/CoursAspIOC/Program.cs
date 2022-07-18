using CoursAspIOC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient(typeof(ServiceA));
builder.Services.AddTransient(typeof(ServiceB));
//builder.Services.AddTransient(typeof(RandomService));
//builder.Services.AddScoped(typeof(RandomService));
builder.Services.AddSingleton(typeof(RandomService));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
