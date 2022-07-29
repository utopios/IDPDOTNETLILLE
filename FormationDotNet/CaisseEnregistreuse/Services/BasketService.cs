using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Services
{
    public class BasketService
    {
        public List<Product> Products { get; set; }

        public decimal Total { get
            {
                decimal total = 0;
                Products.ForEach(p => total += p.Price);
                return total;
            } 
        }

        public BasketService()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
