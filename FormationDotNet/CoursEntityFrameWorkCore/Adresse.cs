using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWorkCore
{
    public class Adresse
    {
        private int id;
        private string street;
        private string city;


        //public Personne Personne { get; set; }
        public int Id { get => id; set => id = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }

        //[ForeignKey("Personne")]
        //public int PersonneId { get; set; }


        public virtual List<Personne> Personnes { get; set; }

    }
}
