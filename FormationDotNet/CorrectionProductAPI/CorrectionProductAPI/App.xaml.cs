﻿using CorrectionProductAPI.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionProductAPI
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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
