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

        public void Demarrer()
        {
            Console.Write("Merci de saisir le nombre de salarié : ");
            nbSalaries = Convert.ToInt32(Console.ReadLine());
            salaries = new Salarie[nbSalaries];
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

        }
        private void ActionAfficherSalaire()
        {

        }

        private void ActionRechercherEmploye()
        {

        }

        private void Suivant()
        {
            Console.WriteLine("Une touche pour continuer ...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
