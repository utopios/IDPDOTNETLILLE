using System;
using System.Collections.Generic;

namespace demoEntityFrameworkDbFirst.Classes
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Phone { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
