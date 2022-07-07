using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireEntityFrameWorkCore.Classes
{
    public class Email
    {
        private int id;
        private string mail;

        [ForeignKey("Contact")]
        public int ContactId { get; set; }

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }

        public Contact Contact { get; set; }
    }
}
