using ProductNavigation.Pages;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductsPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Application is starting");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Application go to background");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("Application is resuming");
        }
    }
}
