﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCompteBancaire.Classes
{
    class Account
    {
        private Customer customer;
        private int accountNumber;
        private decimal totalAmount;

        private List<Operation> operations;

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public Customer Customer { get => customer; set => customer = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }

        public Account(Customer customer, int accountNumber)
        {
            Customer = customer;
            //AccountNumber = (int)DateTime.Now.Ticks;
            AccountNumber = accountNumber;
            Operations = new List<Operation>();
            totalAmount = 0;
        }

        public bool WithDraw(Operation operation)
        {
            if(totalAmount >= Math.Abs(operation.Amount))
            {
                operations.Add(operation);
                totalAmount -= Math.Abs(operation.Amount);
                return true;
            }
            return false;
        }

        public bool Deposit(Operation operation)
        {
            if(operation.Amount > 0)
            {
                operations.Add(operation);
                totalAmount += operation.Amount;
                return true;
            }
            return false;
        }


        //private int createRandomAccountNumber(int size)
        //{
        //    return 0;
        //}
    }
}