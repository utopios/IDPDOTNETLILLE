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

        //Méthode de construction
        public Personne()
        {

        }

        public Personne(string n)
        {
            nom = n;
        }

        public Personne(string n, string p) : this(n)
        {
            //nom = n;
            prenom = p;
        }
        public void Afficher()
        {
            Console.WriteLine($"{nom} {prenom}");
        }
    }
}
