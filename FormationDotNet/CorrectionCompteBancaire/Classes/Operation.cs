using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCompteBancaire.Classes
{
    class Operation
    {
        private decimal amount;
        private DateTime operationDateTime;

        public Operation(decimal amount)
        {
            operationDateTime = DateTime.Now;
            this.amount = amount;
        }
    }
}
