using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWorkCore
{
    public class Personne
    {
        private int id;
        private string name;
        private int age;

        //public Adresse Adresse { get; set; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //[ForeignKey("Adresse")]
        //public int AdresseId { get; set; }

        public virtual List<Adresse> Adresses { get; set; }
    }
}
