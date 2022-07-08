
using BankEntityFrameWork.Repositories;
using BankEntityFrameWork.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Classes
{
    public class Bank
    {
        private string name;
        private List<Account> accounts;
        private DataContext dataContext;

        public string Name { get => name; set => name = value; }
        public List<Account> Accounts { get => accounts; set => accounts = value; }

        public Bank(string name)
        {
            Accounts = new List<Account>();
            Name = name;
            dataContext = new DataContext();
        }

        public Account AddAccount(Customer customer)
        {
            //if (new CustomerDAO().Save(customer))
            //{
            //    Account account = new Account(customer, createRandomAccountNumber(5));
            //    if (new AccountDAO().Save(account))
            //    {
            //        accounts.Add(account);
            //        return account;
            //    }
            //    return null;
            //}
            //return null;

            Account account = new Account(customer, createRandomAccountNumber(5));
            if(new AccountRepository(dataContext).Create(account))
            {
                return account;
            }
            return null;
        }

        public bool MakeWithDraw(decimal amount, int accountNumber)
        {
            //A coder
            Account account = GetAccount(accountNumber);

            if (account != null)
            {
                Operation operation = new Operation(amount);
                
              
 
                return account.WithDraw(operation) && new AccountRepository(dataContext).Update();
            }
            return false;
        }

        public bool MakeDeposit(decimal amount, int accountNumber)
        {
            Account account = GetAccount(accountNumber);
            Operation operation = new Operation(amount);
            return account.Deposit(operation) && new AccountRepository(dataContext).Update();
          
        }

        public Account GetAccount(int number)
        {
            Account account = new AccountRepository(dataContext).Find(c => c.AccountNumber == number);
            return account;
        }
        private int createRandomAccountNumber(int size)
        {
            string code = "";
            Random r = new Random();
            for (int i = 1; i <= size; i++)
            {
                code += r.Next(0, 10);
            }
            return Convert.ToInt32(code);
        }

    }
}
