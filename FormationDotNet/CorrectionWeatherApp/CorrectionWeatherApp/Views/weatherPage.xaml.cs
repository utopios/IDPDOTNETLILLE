using CorrectionWeatherApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class weatherPage : ContentPage
    {
        public weatherPage()
        {
            InitializeComponent();
            
        }

        public weatherPage(string key, string name) : this()
        {
            BindingContext = new WeatherPageViewModel(key, name);
        }
    }
}