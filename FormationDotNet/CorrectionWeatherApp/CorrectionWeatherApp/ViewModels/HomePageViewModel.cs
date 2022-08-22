using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using CorrectionWeatherApp.Helpers;
using CorrectionWeatherApp.Models;
using CorrectionWeatherApp.Services;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace CorrectionWeatherApp.ViewModels
{
    public class HomePageViewModel : MvxViewModel
    {
        private IApiService _apiService;
        public Uri ImageUri { get; set; }
        public string CitySearch { get; set; }
        public ICommand SearchCommand { get; set; }

        public ICommand WeatherCommand { get; set; }

        public ObservableCollection<City> Cities { get; set; }
        private INavigation _navigation;
        public HomePageViewModel(INavigation navigation) 
        {
            Cities = new ObservableCollection<City>();
            SearchCommand = new MvxCommand(ActionSearchCommand);
            WeatherCommand = new MvxCommand<int>(ActionWeatherCommand);
            _navigation = navigation;
            _apiService = ServiceContainer.Container.Resolve<IApiService>();
        }
        public async void ActionSearchCommand()
        {
            Cities = new ObservableCollection<City>(await _apiService.GetCities(CitySearch));
            await RaisePropertyChanged("Cities");
        }

        public void ActionWeatherCommand(int key)
        {
            //Navigation vers la page weather
        }
    }
}
