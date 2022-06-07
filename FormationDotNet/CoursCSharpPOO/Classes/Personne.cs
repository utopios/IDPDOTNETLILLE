using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Personne
    {
        public string nom;
        public string prenom;

        public void Afficher()
        {
            Console.WriteLine($"{nom} {prenom}");
        }
    }
}
