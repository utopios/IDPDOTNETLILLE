using CoursXamarinForms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CoursXamarinForms.Classes;
using Newtonsoft.Json;

namespace CoursXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatricePage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewPage());
        }

        protected async override void OnAppearing()
         {
            HttpClient httpClient = new HttpClient();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://10.0.2.2:5211/weatherforecast");
                HttpContent httpContent = response.Content;
                string content = await response.Content.ReadAsStringAsync();
                List<WeatherForecast> liste = JsonConvert.DeserializeObject<List<WeatherForecast>>(content);
            }
            catch(Exception e)
            {
                
            }
        }
    }
}
