using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.Classes
{
    public class Operation
    {
        private decimal amount;
        private DateTime operationDateTime;

        public Operation(decimal amount)
        {
            operationDateTime = DateTime.Now;
            this.amount = amount;
        }

        public decimal Amount { get => amount; }
        public DateTime OperationDateTime { get => operationDateTime; }
    }
}
