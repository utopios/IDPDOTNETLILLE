using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionWeatherApp.Helpers
{
    public class ServiceContainer
    {       
        private static TinyIoCContainer _container;

        public static TinyIoCContainer Container { get { return _container; } }

        public static void SetupServices()
        {
            if (_container == null)
            {
                _container = new TinyIoCContainer();
            }
        }

    }
}
