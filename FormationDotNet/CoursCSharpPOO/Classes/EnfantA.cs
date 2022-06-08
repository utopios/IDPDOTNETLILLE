using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class EnfantA : Enfant
    {
        public EnfantA(string name, int number) : base(name, number)
        {
        }

        public void AfficherA()
        {
            Console.WriteLine("Je suis un objet A");
        }
    }
}
