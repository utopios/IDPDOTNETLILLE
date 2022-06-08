using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Salarie
    {
        private string matricule;
        private string nom;
        private string categorie;
        private string service;
        private decimal salaire;
        private static decimal totalSalaire = 0;
        private static int compteur = 0;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public decimal Salaire
        {
            get => salaire; set
            {
                if(salaire> 0)
                {
                    totalSalaire -= salaire;
                }
                totalSalaire += value;
                salaire = value;
            }
        }
        public static decimal TotalSalaire { get => totalSalaire; }
        public static int Compteur { get => compteur; }

        public Salarie(string matricule, string nom, string categorie, string service, decimal salaire)
        {
            Matricule = matricule;
            Nom = nom;
            Categorie = categorie;
            Service = service;
            Salaire = salaire;
            compteur++;
        }

        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }

        public static void ResetCompteur(int valeur = 0)
        {
            compteur = valeur;
        }

        public virtual decimal CalculerSalaire()
        {
            return Salaire;
        }
    }
}
