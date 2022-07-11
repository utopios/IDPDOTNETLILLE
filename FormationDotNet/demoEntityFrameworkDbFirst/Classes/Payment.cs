using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class Payment
    {
        public Payment()
        {
            CardPaymentPayments = new HashSet<CardPayment>();
            CashPaymentPayments = new HashSet<CashPayment>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual CardPayment CardPaymentIdNavigation { get; set; } = null!;
        public virtual CashPayment CashPaymentIdNavigation { get; set; } = null!;
        public virtual ICollection<CardPayment> CardPaymentPayments { get; set; }
        public virtual ICollection<CashPayment> CashPaymentPayments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
