using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Classes
{
    public abstract class Payment
    {
        private int id;
        private string reference;
        private DateTime paymentDate;
        protected decimal amount;

        public int Id { get => id; set => id = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }

        protected Payment()
        {
            reference = Guid.NewGuid().ToString();
            PaymentDate = DateTime.Now;
        }

        public abstract bool Pay(decimal amount);
    }
}
