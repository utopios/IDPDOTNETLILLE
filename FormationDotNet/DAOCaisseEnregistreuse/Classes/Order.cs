using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.Classes
{
    public class Order
    {
        private int id;
        private List<ProductOrder> products;
        private Payment payment;
        private static int count;

        public int Id { get => id; set => id = value; }
        public List<ProductOrder> Products { get => products; set => products = value; }
        public Payment Payment { get => payment; set => payment = value; }
        
        public decimal Total
        {
            get
            {
                decimal total = 0;
                Products.ForEach(p =>
                {
                    total += p.Qty * p.Product.Price;
                });
                return total;
            }
        }
        public Order()
        {
            
            Products = new List<ProductOrder>();
        }

        public bool AddProduct(Product product)
        {
            ProductOrder productOrder = Products.Find(p => p.Product.Id == product.Id);
            if(productOrder == null)
            {
                productOrder = new ProductOrder() { Product = product, Qty = 1};
                products.Add(productOrder);

            }
            else
            {
                productOrder.Qty += 1;
            }
            return true;
        }

        public bool Pay(Payment payment)
        {
            Payment = payment;
            return Payment.Pay(Total);
        }
    }
}
