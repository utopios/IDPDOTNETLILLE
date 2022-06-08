using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class IHMSalarieHeritage
    {
        private Salarie[] salaries;
        private int nbSalaries;
        private string choix;
        private string choixAjout;
        private int compteur;

        public void Demarrer()
        {
            Console.Write("Merci de saisir le nombre de salarié : ");
            nbSalaries = Convert.ToInt32(Console.ReadLine());
            salaries = new Salarie[nbSalaries];
            compteur = 0;
            Console.Clear();
            do
            {
                Menu();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionAjoutEmploye();
                        break;
                    case "2":
                        ActionAfficherSalaire();
                        break;
                    case "3":
                        ActionRechercherEmploye();
                        break;
                }
            } while (choix != "0");
        }

        private void Menu()
        {
            Console.WriteLine("1 -- Ajouter un employé ");
            Console.WriteLine("2 -- Afficher le salaire des employés");
            Console.WriteLine("3 -- Rechercher un employé");
            Console.WriteLine("0 -- Quitter");
        }

        private void MenuAjout()
        {
            Console.WriteLine("1 -- Ajouter un salarié ");
            Console.WriteLine("2 -- Ajouter un commercial");
            Console.WriteLine("0 -- Retour");
        }

        private void ActionAjoutEmploye()
        {
            do
            {
                MenuAjout();
                choixAjout = Console.ReadLine();
                Console.Clear();
                if((choixAjout == "1" || choixAjout == "2") && compteur < salaries.Length)
                {
                    Salarie s = null;
                    Console.Write("Merci de saisir le nom complet : ");
                    string nom = Console.ReadLine();
                    Console.Write("Merci de saisir le matricule : ");
                    string matricule = Console.ReadLine();
                    Console.Write("Merci de saisir le catégorie : ");
                    string categorie = Console.ReadLine();
                    Console.Write("Merci de saisir le service : ");
                    string service = Console.ReadLine();
                    Console.Write("Merci de saisir le salaire : ");
                    decimal salaire = Convert.ToDecimal(Console.ReadLine());
                    switch (choixAjout)
                    {
                        case "1":
                            s = new Salarie(matricule, nom, categorie, service, salaire);
                            break;
                        case "2":
                            Console.Write("Merci de saisir le chiffre d'affaire : ");
                            decimal chiffre = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Merci de saisir la commisison en % : ");
                            decimal commission = Convert.ToDecimal(Console.ReadLine());
                            s = new Commercial(matricule, nom, categorie, service, salaire, chiffre, commission);
                            break;
                    }
                    if(s != null)
                    {
                        salaries[compteur++] = s; 
                    }
                }
            } while (choixAjout != "0");
            

        }
        private void ActionAfficherSalaire()
        {
            foreach(Salarie s in salaries)
            {
                Console.WriteLine($"{s.Nom} salaire : {s.CalculerSalaire()} euros : {s.GetType()}");
            }
            Suivant();
        }

        private void ActionRechercherEmploye()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            foreach(Salarie s in salaries)
            {
                if(s != null && s.Nom == nom)
                {
                    Console.WriteLine($"{s.Nom} salaire : {s.CalculerSalaire()} euros : {s.GetType()}");
                }
            }
            Suivant();
        }

        private void Suivant()
        {
            Console.WriteLine("Une touche pour continuer ...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
