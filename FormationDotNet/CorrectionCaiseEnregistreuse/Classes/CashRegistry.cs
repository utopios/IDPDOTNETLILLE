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

        public CashRegistry()
        {
            products = new List<Product>();
            orders = new List<Order>();
        }

        public Product GetProductById(int id)
        {
            //A Coder
            return null;
        }

        public Product AddProduct(Product product)
        {
            //A Coder
            return product;
        }

        public Order AddOrder(Order order, Payment payment)
        {
            //A coder
            return order;
        }
    }
}
