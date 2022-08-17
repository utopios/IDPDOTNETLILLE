using ProductXamarin.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductPageScroll();
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
