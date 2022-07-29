using CaisseEnregistreuse.Interfaces;
using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Services;
public class ProductService : IProductService
{
    private List<Product> _products;
    private List<Product> _searchProducts;
    public event Action ProductsChanged;
    public event Action SearchChanged;
    public ProductService()
    {
        _searchProducts = new List<Product>();
        _products = new List<Product>() { new Product() { Id =1, Title="product 1", Price=10, Stock=10} };
    }

    public List<Product> Products { get => _products; }
    public List<Product> SearchProducts { get => _searchProducts; set => _searchProducts = value; }

    public bool AddProduct(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
        ProductsChanged?.Invoke();
        return true;
    }

    public Product GetProductById(int id)
    {
        return _products.Find(p => p.Id == id);
    }

    public void SearchProductTitle(string search)
    {
        _searchProducts = _products.Where(p => p.Title.Contains(search)).ToList();
        SearchChanged?.Invoke();
    }
}

