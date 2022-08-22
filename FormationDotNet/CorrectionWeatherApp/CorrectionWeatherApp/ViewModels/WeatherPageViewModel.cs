using CorrectionWeatherApp.Helpers;
using CorrectionWeatherApp.Models;
using CorrectionWeatherApp.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CorrectionWeatherApp.ViewModels
{
    public class WeatherPageViewModel: MvxViewModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        private IApiService _apiService;

        public List<Forecast> WeatherConditions { get; set; }

        public ICommand AppearedCommand { get; set; }
        public WeatherPageViewModel(string key, string name)
        {
            Key = key;
            Name = name;
            WeatherConditions = new List<Forecast>();
            _apiService = ServiceContainer.Container.Resolve<IApiService>();
            AppearedCommand = new MvxCommand(ViewAppeared);
        }

        public async override void ViewAppeared()
        {
            WeatherConditions = new List<Forecast>((await _apiService.GetWeatherConditions(Key)).DailyForecasts);
            await RaisePropertyChanged("WeatherConditions");
        }
    }
}
