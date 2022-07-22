using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Classes
{
    [Table("account")]
    public class Account
    {
        private int id;
        private Customer customer;
        private int accountNumber;
        private decimal totalAmount;

        private List<Operation> operations;

        [Column("account_number")]
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }

        [Column("total_amount")]
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get => customer; set => customer = value; }
        public virtual List<Operation> Operations { get => operations; set => operations = value; }
        public int Id { get => id; set => id = value; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public Account()
        {
            //TotalAmount = 0;
            Operations = new List<Operation>();
            Customer = new Customer();
        }
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
