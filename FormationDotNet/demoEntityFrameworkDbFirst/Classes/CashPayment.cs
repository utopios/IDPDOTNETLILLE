using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class CashPayment
    {
        public int Id { get; set; }
        public decimal Change { get; set; }
        public int PaymentId { get; set; }

        public virtual Payment IdNavigation { get; set; } = null!;
        public virtual Payment Payment { get; set; } = null!;
    }
}
