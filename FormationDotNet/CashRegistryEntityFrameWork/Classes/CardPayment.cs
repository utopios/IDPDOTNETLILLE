using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Classes
{
    [Table("card_payment")]

    public class CardPayment : Payment
    {
        public int Id { get; set; }
        public override bool Pay(decimal amount)
        {
            //Pour tester le paiement accépté et refusé
            return amount % 2 == 0;
        }
        public int PaymentId {get;set;}

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
    }
}
