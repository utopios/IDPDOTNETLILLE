using Microsoft.Extensions.DependencyInjection;
using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionProductAPI.Services
{
    public class ServiceContainer
    {
        //private static ServiceProvider serviceProvider;

        //public static ServiceProvider ServiceProvider
        //{
        //    get
        //    {
        //        //SetupService();
        //        return serviceProvider;
        //    }
        //}
        //public static void SetupServices()
        //{
        //    if (serviceProvider == null)
        //    {
        //        IServiceCollection services = new ServiceCollection();
        //        serviceProvider = services.BuildServiceProvider();
        //        services.AddScoped<ProductApiService>();
        //    }
        //}

        private static TinyIoCContainer _container;

        public static TinyIoCContainer Container { get { return _container; } }

        public static void SetupServices()
        {
            if(_container == null)
            {
                _container = new TinyIoCContainer();
                _container.Register<ProductApiService>();
            }
        }

    }
}
