using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Interfaces
{
    public interface IProductService
    {
        public List<Product> Products { get; }
        public bool AddProduct(Product product);
        public Product GetProductById(int id);
    }
}
