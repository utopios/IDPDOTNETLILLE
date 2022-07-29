using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Interfaces
{
    public interface IProductService
    {
        public List<Product> Products { get; }
        public event Func<Task> ProductsChanged;
        public event Action SearchChanged;
        public List<Product> SearchProducts { get; }
        public Task<bool> AddProduct(Product product);
        public Product GetProductById(int id);
        public Task<List<Product>> GetProducts();
        public void SearchProductTitle(string title);
    }
}
