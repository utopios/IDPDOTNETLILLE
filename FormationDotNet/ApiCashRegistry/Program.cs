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
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
