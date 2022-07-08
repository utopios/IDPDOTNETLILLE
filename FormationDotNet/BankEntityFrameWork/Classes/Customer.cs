using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Classes
{
    [Table("customer")]
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        //private static int count = 0;

        public int Id { get => id; set => id = value; }

        [Column("phone")]
        [StringLength(10)]
        [Required]
        public string Phone { get => phone; set => phone = value; }

        [Column("first_name")]
        [StringLength(maximumLength:255)]
        [Required]
        public string FirstName { get => firstName; set => firstName = value; }

        [Column("last_name")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string LastName { get => lastName; set => lastName = value; }

        public Customer()
        {

        }
        public Customer(string phone, string firstName, string lastName)
        {
            //Id = ++count;
            Phone = phone;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Prénom {FirstName}, Nom : {LastName}";
        }
        public override bool Equals(object? obj)
        {
            Customer c = (Customer)obj;
            return FirstName == c.FirstName && LastName == c.LastName;
        }
    }
}
