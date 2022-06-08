using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class EnfantB : Enfant
    {
        public EnfantB(string name, int number) : base(name, number)
        {
        }

        public void AfficherB()
        {
            Console.WriteLine("Je suis un objet B");
        }
    }
}
