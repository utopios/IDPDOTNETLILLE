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
using Xamarin.Essentials;
using System.Diagnostics;

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

            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }

            HttpClient httpClient = new HttpClient();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://10.0.2.2:5104/api/v1/product");
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
