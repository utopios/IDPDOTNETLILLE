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
builder.Services.AddScoped<BaseRepository<Utilisateur>, UtilisateurRepository>();
builder.Services.AddTransient<IUpload, UploadService>();
builder.Services.AddScoped<ToolsService>();
builder.Services.AddScoped<ILogin, CookieLoginService>();
builder.Services.AddHttpContextAccessor();
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
