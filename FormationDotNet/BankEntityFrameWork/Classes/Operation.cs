using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Classes
{
    public class Operation
    {
        private int id;
        private decimal amount;
        private DateTime operationDateTime;
        private int accountId;
        public Operation(decimal amount)
        {
            operationDateTime = DateTime.Now;
            this.amount = amount;
        }

        public decimal Amount { get => amount; }
        public DateTime OperationDateTime { get => operationDateTime; set => operationDateTime = value; }
        public int Id { get => id; set => id = value; }
        public int AccountId { get => accountId; set => accountId = value; }
    }
}
