using CaisseEnregistreuse;
using CaisseEnregistreuse.Interfaces;
using CaisseEnregistreuse.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IProductService,ProductAPIService>();
builder.Services.AddSingleton<BasketService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5104") });

await builder.Build().RunAsync();
