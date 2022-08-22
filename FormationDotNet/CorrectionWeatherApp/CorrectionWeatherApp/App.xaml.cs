using CorrectionWeatherApp.Helpers;
using CorrectionWeatherApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ServiceContainer.SetupServices();
            MainPage = new NavigationPage(new HomePage());
        }

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
