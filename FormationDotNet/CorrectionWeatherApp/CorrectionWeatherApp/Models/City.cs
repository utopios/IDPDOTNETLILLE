using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionWeatherApp.Models
{
    public class City
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }

        public Country Country { get; set; }

        public City()
        {
            Country = new Country();
        }
    }

    public class Country
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }

        public Country()
        {

        }
    }
}
