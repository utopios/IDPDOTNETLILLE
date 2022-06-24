using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.Classes
{
    public abstract class Payment
    {
        private string reference;
        private DateTime paymentDate;
        protected decimal amount;

        protected Payment()
        {
            reference = Guid.NewGuid().ToString();
            paymentDate = DateTime.Now;
        }

        public abstract bool Pay(decimal amount);
    }
}
