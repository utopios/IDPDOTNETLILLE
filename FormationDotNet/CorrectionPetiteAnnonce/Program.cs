using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using CorrectionPetiteAnnonce.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContextService>();
builder.Services.AddScoped<BaseRepository<Annonce>, AnnonceRepository>();
builder.Services.AddScoped<BaseRepository<Categorie>, CategorieRepository>();
builder.Services.AddScoped<BaseRepository<Utilisateur>, UtilisateurRepository>();
builder.Services.AddTransient<IUpload, UploadService>();
builder.Services.AddScoped<ToolsService>();
//builder.Services.AddScoped<ILogin, CookieLoginService>();
//builder.Services.AddScoped<ILogin, SessionLoginService>();
builder.Services.AddScoped<ILogin, JwtLoginService>();
builder.Services.AddScoped<FavorisService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddCors(options =>
{
    options.AddPolicy("react", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "m2i",
        ValidAudience = "m2i",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto"))
    };
});

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
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Annonce}/{action=Index}/{id?}");

app.Run();
