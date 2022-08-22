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
            _httpClient = new HttpClient() { BaseAddress = new Uri(@"https://dataservice.accuweather.com/") };
        }
        public async Task<IEnumerable<City>> GetCities(string search)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"locations/v1/cities/search?apikey={_apiKey}&q={search}");
            string content = await (response.Content).ReadAsStringAsync();
            IEnumerable<City> cityList = new List<City>();
            try
            {
                cityList = JsonConvert.DeserializeObject<List<City>>(content);
            }catch(Exception ex)
            {

            }
            return cityList;
        }

        public async Task<City> GetCity(string lat, string lon)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"locations/v1/cities/geoposition/search?apikey={_apiKey}&q={lat},{lon}");
            string content = await (response.Content).ReadAsStringAsync();
            City city = null;
            try
            {
                city = JsonConvert.DeserializeObject<City>(content);
            }
            catch (Exception ex)
            {

            }
            return city;
        }

        public async Task<WeatherCondition> GetWeatherConditions(string key)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"forecasts/v1/daily/5day/{key}?apikey={_apiKey}&language=fr-fr&metric=true");
            string content = await (response.Content).ReadAsStringAsync();
            WeatherCondition conditions = null;
            try
            {
                conditions = JsonConvert.DeserializeObject<WeatherCondition>(content);
            }
            catch (Exception ex)
            {

            }
            return conditions;
        }
    }
}
