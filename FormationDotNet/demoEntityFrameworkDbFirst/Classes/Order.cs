using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }
        public int PaymentId { get; set; }

        public virtual Payment Payment { get; set; } = null!;
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
