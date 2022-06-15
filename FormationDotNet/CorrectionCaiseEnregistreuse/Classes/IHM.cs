using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCaisseEnregistreuse.Classes
{
    class IHM
    {
        private CashRegistry cashRegistry;

        public IHM()
        {
            cashRegistry = new CashRegistry();
        }

        public void Start()
        {
            string choice;
            do
            {
                Menu();
                choice = Console.ReadLine();
                Console.Clear();
                switch(choice)
                {
                    case "1":
                        CreateProductAction();
                        break;
                    case "2":
                        StartOrderAction();
                        break;
                }
            } while (choice != "0");
        }

        private void Menu()
        {
            Console.WriteLine("1 - Ajouter un produit dans la caisse ");
            Console.WriteLine("2 - Faire une vente ");
            Console.WriteLine("0 - Quitter ");
        }

        private void SubMenu()
        {
            Console.WriteLine("1 - Numéro de produit à vendre ");
            Console.WriteLine("2 - Paiement par carte");
            Console.WriteLine("0 - Paiement espèce");
        }

        private void CreateProductAction()
        {
            Console.Write("Titre produit : ");
            string title = Console.ReadLine();
            decimal price;
            int stock;
            do
            {
                Console.Write("Merci de saisir le prix : ");
            } 
            while (!decimal.TryParse(Console.ReadLine(), out price));
            do
            {
                Console.Write("Merci de saisir le stock : ");
            }
            while (!int.TryParse(Console.ReadLine(), out stock));
            Product p = new Product(title, price, stock);
            if(cashRegistry.AddProduct(p) != null)
            {
                Console.WriteLine("Produit ajouté avec l'id " + p.Id);
            }else
            {
                Console.WriteLine("Erreur d'ajout du produit");
            }
        }

        private void StartOrderAction()
        {

        }
    }
}
