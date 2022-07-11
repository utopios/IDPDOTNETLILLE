using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class Account
    {
        public Account()
        {
            Operations = new HashSet<Operation>();
        }

        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
