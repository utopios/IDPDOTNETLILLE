using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCaisseEnregistreuse.Classes
{
    class CashRegistry
    {
        private List<Product> products;
        private List<Order> orders;

        public List<Product> Products { get => products; set => products = value; }
        public List<Order> Orders { get => orders; set => orders = value; }

        public CashRegistry()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        public Product GetProductById(int id)
        {
            //A Coder
            return Products.Find( p=> p.Id == id);
        }

        public Product AddProduct(Product product)
        {
            //A Coder
            Products.Add(product);
            return product;
        }

        public bool AddOrder(Order order, Payment payment)
        {
            //A coder
            if (order.Pay(payment))
            {
                Orders.Add(order);
                return true;
            }
            return false;
        }
    }
}
