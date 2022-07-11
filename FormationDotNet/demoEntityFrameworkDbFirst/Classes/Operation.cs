using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class Operation
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime OperationDateTime { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
