using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireEntityFrameWorkCore.Classes
{
    [Table("contact_entity")]
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;

        public int Id { get => id; set => id = value; }

        [Column("first_name")]
        public string FirstName { get => firstName; set => firstName = value; }
        
        [Column("last_name")]
        public string LastName { get => lastName; set => lastName = value; }
        
        [Column("phone")]
        public string Phone { get => phone; set => phone = value; }
    }
}
