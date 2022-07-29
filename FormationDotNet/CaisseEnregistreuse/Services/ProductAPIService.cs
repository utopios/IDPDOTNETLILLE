using CaisseEnregistreuse.Interfaces;
using CaisseEnregistreuse.Models;
using System.Net.Http.Json;

namespace CaisseEnregistreuse.Services
{
    public class ProductAPIService : IProductService
    {
        private HttpClient _httpClient;
        public ProductAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Product> Products => throw new NotImplementedException();

        public List<Product> SearchProducts => throw new NotImplementedException();

        public event Func<Task> ProductsChanged;
        public event Action SearchChanged;

        public async Task<bool> AddProduct(Product product)
        {
            HttpResponseMessage reponse = await _httpClient.PostAsJsonAsync<Product>("/api/v1/product", product);
            await ProductsChanged?.Invoke();
            return reponse.IsSuccessStatusCode;
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("/api/v1/product");
        }

        public void SearchProductTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
