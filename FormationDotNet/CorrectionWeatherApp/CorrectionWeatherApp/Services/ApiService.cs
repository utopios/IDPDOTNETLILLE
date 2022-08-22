using CorrectionWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionWeatherApp.Services
{
    public class ApiService : IApiService
    {
        private HttpClient _httpClient;
        private string _apiKey;
        public ApiService()
        {
            _apiKey = "eAHd9lgJ7X4TgO9n0e13ljbPp56z8SD3";
            _httpClient = new HttpClient() { BaseAddress = new Uri(@"http://dataservice.accuweather.com/") };
        }
        public async Task<IEnumerable<City>> GetCities(string search)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"locations/v1/cities/search?apikey={_apiKey}&q={search}");
            IEnumerable<City> cityList = JsonConvert.DeserializeObject<IEnumerable<City>>(await(response.Content).ReadAsStringAsync());
            return cityList;
        }
    }
}
