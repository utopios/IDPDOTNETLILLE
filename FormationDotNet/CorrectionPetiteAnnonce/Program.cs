using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using CorrectionPetiteAnnonce.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContextService>();
builder.Services.AddScoped<BaseRepository<Annonce>, AnnonceRepository>();
builder.Services.AddScoped<BaseRepository<Categorie>, CategorieRepository>();
builder.Services.AddTransient<IUpload, UploadService>();
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
    pattern: "{controller=Annonce}/{action=Index}/{id?}");

app.Run();
