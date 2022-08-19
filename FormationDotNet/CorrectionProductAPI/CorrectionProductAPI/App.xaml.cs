using CorrectionProductAPI.Pages;
using CorrectionProductAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionProductAPI
{
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;
        public App()
        {
            InitializeComponent();
            //SetupService();
            ServiceContainer.SetupServices();
            MainPage = new NavigationPage(new ProductsPage());
        }

        //private void SetupService()
        //{
        //    IServiceCollection services = new ServiceCollection();
        //    serviceProvider = services.BuildServiceProvider();
        //    services.AddScoped<ProductApiService>();

        //}
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
