using CorrectionWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionWeatherApp.Services
{
    public interface IApiService
    {
        Task<IEnumerable<City>> GetCities(string search);
    }
}
