using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Personne
    {
        private string nom;
        private string prenom;
        public static int Nombre = 0;

        //Méthode de construction
        public Personne()
        {

        }

        public Personne(string ne) : this()
        {
            nom = ne;
        }



        public Personne(string n, string p) : this(n)
        {
            //nom = n;
            Prenom = p;
        }
        public void Afficher()
        {
            Console.WriteLine($"{nom} {Prenom}");
        }

        //public void SetNom(string nom)
        //{
        //    if(nom.Length > 3)
        //        this.nom = nom;
        //}

        //public void SetPrenom(string prenom)
        //{
        //    this.prenom= prenom;
        //}

        public string Nom
        {
            get { return nom; }
            set 
            {
                if (value.Length > 3)
                    nom = value;
            }
        }

        public string Prenom { get => prenom; set => prenom = value; }

        public static Personne[] TableauPersonnes()
        {
            Personne[] personnes = new Personne[3];
            return personnes;
        }
    }
}
