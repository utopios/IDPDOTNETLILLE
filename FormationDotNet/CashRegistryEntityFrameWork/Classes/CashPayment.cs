using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Classes
{
    [Table("cash_payment")]
    public class CashPayment : Payment
    {
        private decimal change;
        private decimal givenAmount;
        public int Id { get; set; }

        public decimal Change { get => change; set => change = value; }

        public CashPayment()
        {

        }
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

        public int PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
    }
}
