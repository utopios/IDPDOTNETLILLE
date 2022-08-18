using CorrectionProductAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionProductAPI.Services
{
    public class ProductApiService
    {
        private HttpClient _httpClient;

        public ProductApiService()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("http://10.0.2.2:5104/api/v1/") };
        }

        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = new List<Product>();
            HttpResponseMessage response = await _httpClient.GetAsync("product");
            string stringContent = await response.Content.ReadAsStringAsync();
            products = JsonConvert.DeserializeObject<List<Product>>(stringContent);
            return products;
        }

        public async Task<Product> PostProduct(Product product)
        {
            string json = JsonConvert.SerializeObject(product);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("product", content);
            string stringContent = await response.Content.ReadAsStringAsync();
            Product resultProduct = JsonConvert.DeserializeObject<Product>(stringContent);
            return resultProduct;
        }
    }
}
