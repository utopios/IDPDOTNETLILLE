using ApiCashRegistry.Services;
using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CashRegistryEntityFrameWork.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<BaseRepository<Product>, ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<BaseRepository<Order>, OrderRepository>();
builder.Services.AddScoped<OrderService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("allRequest", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });

    options.AddPolicy("allRequestOnlyGetVerb", builder =>
    {
        builder.AllowAnyOrigin().WithMethods("GET").AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseCors("allRequest");
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
