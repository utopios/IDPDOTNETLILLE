using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.Classes
{
    public class CardPayment : Payment
    {
        public override bool Pay(decimal amount)
        {
            //Pour tester le paiement accépté et refusé
            return amount % 2 == 0;
        }
    }
}
