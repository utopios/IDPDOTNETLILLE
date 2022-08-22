using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using CorrectionWeatherApp.Models;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace CorrectionWeatherApp.ViewModels
{
    public class HomePageViewModel : MvxViewModel
    {
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
        }
        public void ActionSearchCommand()
        {

        }

        public void ActionWeatherCommand(int key)
        {
            //Navigation vers la page weather
        }
    }
}
