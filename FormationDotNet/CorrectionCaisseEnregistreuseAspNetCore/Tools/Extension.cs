using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using CorrectionCaisseEnregistreuseAspNetCore.Services;

namespace CorrectionCaisseEnregistreuseAspNetCore.Tools
{
    public static class Extension
    {
        public static void AddAllServices(this IServiceCollection Services)
        {
            Services.AddScoped<BaseRepository<Product>, ProductRepository>();
            Services.AddScoped<BaseRepository<Order>, OrderRepository>();
            Services.AddScoped<BaseRepository<CashRegistryUser>, CashRegistryUserRepository>();
            Services.AddScoped<ICart, CartSessionService>();
            Services.AddScoped<ILogin, LoginSessionService>();
        }
    }
}
