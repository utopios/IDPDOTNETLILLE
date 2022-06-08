using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Enfant : Parent
    {
        private int childNumber;

        public int ChildNumber { get => childNumber; set => childNumber = value; }

        
        public Enfant(string name, int number) : base(name, number) 
        {

        }
        public void AfficherEnfant()
        {
            Afficher();
            Console.WriteLine($"{ChildNumber}");
        }
    }
}
