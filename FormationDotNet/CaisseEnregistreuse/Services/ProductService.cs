using CaisseEnregistreuse.Interfaces;
using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Services;
public class ProductService : IProductService
{
    private List<Product> _products;

    public ProductService()
    {
        _products = new List<Product>() { new Product() { Id =1, Title="product 1", Price=10, Stock=10} };
    }

    public List<Product> Products { get => _products; }

    public bool AddProduct(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
        return true;
    }

    public Product GetProductById(int id)
    {
        return _products.Find(p => p.Id == id);
    }
}

