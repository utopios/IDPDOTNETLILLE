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

        public Account AddAccount(Customer customer)
        {
            Account account = new Account(customer, createRandomAccountNumber(5));
            accounts.Add(account);
            return account;
        }

        public bool MakeWithDraw(decimal amount, int accountNumber)
        {
            //A coder
            Account account = GetAccount(accountNumber);
            if(account != null)
            {
                Operation operation = new Operation(amount);
                return account.WithDraw(operation);
            }
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
            Account account = null;
            foreach(Account a in accounts)
            {
                if(account.AccountNumber == number)
                {
                    account = a;
                    break;
                }
            }
            return account;
        }
        private int createRandomAccountNumber(int size)
        {
            string code = "";
            Random r = new Random();
            for(int i= 1; i <= size; i++)
            {
                code += r.Next(0, 10);
            }
            return Convert.ToInt32(code);
        }

    }
}
