using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionWeatherApp.ViewModels
{
    public class WeatherPageViewModel: MvxViewModel
    {
        public string Key { get; set; }
        public WeatherPageViewModel(string key)
        {
            Key = key;
        }
    }
}
