using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionWeatherApp.Models
{
    public class City
    {
        public int key { get; set; }
        public string LocalizedName { get; set; }

        public Country Country { get; set; }


    }

    public class Country
    {
        public int ID { get; set; }
        public string LocalizedName { get; set; }
    }
}
