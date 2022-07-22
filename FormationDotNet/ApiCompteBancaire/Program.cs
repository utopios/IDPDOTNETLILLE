using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Repositories;
using BankEntityFrameWork.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<BaseRepository<Customer>, CustomerRepository>();
builder.Services.AddScoped<BaseRepository<Account>, AccountRepository>();
builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
