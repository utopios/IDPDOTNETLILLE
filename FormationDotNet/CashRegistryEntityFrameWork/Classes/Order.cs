using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Classes
{
    
    public class Order
    {
        private int id;
        private ObservableCollection<ProductOrder> products;
        private Payment payment;
        private static int count;

        public int Id { get => id; set => id = value; }
        public virtual ObservableCollection<ProductOrder> Products { get => products; set => products = value; }
        
        [ForeignKey("PaymentId")]
        public Payment Payment { get => payment; set => payment = value; }        
        public int PaymentId { get; set; }

        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (ProductOrder p in products)
                {
                    total += p.Qty * p.Product.Price;
                }
                //Products.ForEach(p =>
                //{
                //    total += p.Qty * p.Product.Price;
                //});
                return total;
            }
            
        }
        public Order()
        {
            
            Products = new ObservableCollection<ProductOrder>();
        }

        public bool AddProduct(Product product)
        {
            ProductOrder productOrder = Products.ToList().Find(p => p.Product.Id == product.Id);
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
        public ProductOrder AddProduct(Product product,bool test)
        {
            ProductOrder productOrder = Products.ToList().Find(p => p.Product.Id == product.Id);
            if (productOrder == null)
            {
                productOrder = new ProductOrder() { Product = product, Qty = 1 };
                products.Add(productOrder);

            }
            else
            {
                productOrder.Qty += 1;
            }
            return productOrder;
        }

        public bool DeleteProduct(ProductOrder product)
        {
            ProductOrder productOrder = Products.ToList().Find(p => p.Product.Id == product.Product.Id);
            if (productOrder != null)
            {
                if(productOrder.Qty > 1)
                {
                    productOrder.Qty--;
                }
                else
                {
                    products.Remove(productOrder);
                }
                return true;
            }
          
            return false;
        }

        public bool Pay(Payment payment)
        {
            Payment = payment;
            return Payment.Pay(Total);
        }
    }
}
