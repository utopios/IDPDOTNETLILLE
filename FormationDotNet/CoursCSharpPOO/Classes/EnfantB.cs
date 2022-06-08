using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class EnfantB : Parent
    {
        public EnfantB(string name, int number) : base(name, number)
        {
        }

        public new void Afficher()
        {
            Console.WriteLine("Methode afficher special B");
        }

        public void AfficherB()
        {
            Console.WriteLine("Je suis un objet B");
        }
    }
}
