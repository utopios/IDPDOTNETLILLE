using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCompteBancaire.Classes
{
    class Bank
    {
        private string name;
        private List<Account> accounts;

        public string Name { get => name; set => name = value; }
        public List<Account> Accounts { get => accounts; set => accounts = value; }

        public Bank(string name)
        {
            Accounts = new List<Account>();
        }

        public bool AddAccount(Customer customer)
        {
            //A coder

            return false;
        }

        public bool MakeWithDraw(decimal amount)
        {
            //A coder
            return false;
        }

        public bool MakeDeposit(decimal amount)
        {
            //A coder
            return false;
        }

        public Account GetAccount(int number)
        {
            //A coder
            return null;
        }
        private int createRandomAccountNumber(int size)
        {
            return 0;
        }

    }
}
