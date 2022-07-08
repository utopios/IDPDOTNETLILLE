
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

        public string Name { get => name; set => name = value; }
        public List<Account> Accounts { get => accounts; set => accounts = value; }

        public Bank(string name)
        {
            Accounts = new List<Account>();
            Name = name;
        }

        //public Account AddAccount(Customer customer)
        //{
        //    if (new CustomerDAO().Save(customer)) {
        //        Account account = new Account(customer, createRandomAccountNumber(5));
        //        if (new AccountDAO().Save(account)) { 
        //            accounts.Add(account);
        //            return account;
        //        }
        //        return null;
        //    }
        //    return null;
        //}

        //public bool MakeWithDraw(decimal amount, int accountNumber)
        //{
        //    //A coder
        //    Account account = GetAccount(accountNumber);

        //    if (account != null)
        //    {
        //        Operation operation = new Operation(amount);
        //        operation.AccountId = account.Id;
        //        //if(new OperationDAO().Save(operation))
        //        //{
        //        //    if(new AccountDAO().Update(account))
        //        //        return account.WithDraw(operation);
        //        //}
        //        return new OperationDAO().Save(operation) && account.WithDraw(operation) && new AccountDAO().Update(account);
        //    }
        //    return false;
        //}

        //public bool MakeDeposit(decimal amount, int accountNumber)
        //{
            
        //    Account account = GetAccount(accountNumber);
        //    if (account != null)
        //    {
        //        SqlConnection connection = DataBase.Connection;
        //        connection.Open();
        //        SqlTransaction transaction = connection.BeginTransaction();
        //        Operation operation = new Operation(amount);
        //        operation.AccountId = account.Id;
        //        bool result = new OperationDAO(connection, transaction).Save(operation) && account.Deposit(operation) && new AccountDAO(connection, transaction).Update(account);
        //        if(result)
        //        {
        //            transaction.Commit();
        //        }else
        //        {
        //            transaction.Rollback();
        //        }
        //        connection.Close();
        //        return result;
        //    }
        //    return false;
        //}

        //public Account GetAccount(int number)
        //{
        //    //A coder
        //    //DAO
        //    Account account = new AccountDAO().GetWithAccountNumber(number);
        //    //foreach (Account a in accounts)
        //    //{
        //    //    if (a.AccountNumber == number)
        //    //    {
        //    //        account = a;
        //    //        break;
        //    //    }
        //    //}
        //    return account;
        //}
        //private int createRandomAccountNumber(int size)
        //{
        //    string code = "";
        //    Random r = new Random();
        //    for (int i = 1; i <= size; i++)
        //    {
        //        code += r.Next(0, 10);
        //    }
        //    return Convert.ToInt32(code);
        //}

    }
}
