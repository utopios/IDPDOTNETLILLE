using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionWeatherApp.Models
{
    public class WeatherCondition
    {
        public DateTime Date { get; set; }

        public Temperature Temperature {get;set; }

        public IconWeather Day { get; set; }

        public IconWeather Night { get; set; }
    }

    public class Temperature
    {
        public TemperatureValue Minimum { get; set; }
        public TemperatureValue Maximum { get; set; }
    }

    public class TemperatureValue
    {
        public double Value { get; set; }
    }

    public class IconWeather
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
    }
}
