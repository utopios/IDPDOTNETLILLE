using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.Classes
{
    public class CashPayment : Payment
    {
        private decimal change;
        private decimal givenAmount;

        public decimal Change { get => change; set => change = value; }

        public CashPayment(decimal givenAmout)
        {
            this.givenAmount = givenAmout;
        }

        public override bool Pay(decimal amount)
        {
            if(givenAmount >= amount)
            {
                change = givenAmount - amount;
                return true;
            }
            return false;
        }
    }
}
