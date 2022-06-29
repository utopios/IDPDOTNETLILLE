using DAOCaisseEnregistreuse.Classes;
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
        private Order order;
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
                switch (choice)
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
            Console.WriteLine("3 - Paiement espèce");
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
            if (cashRegistry.AddProduct(p) != null)
            {
                Console.WriteLine("Produit ajouté avec l'id " + p.Id);
            }
            else
            {
                Console.WriteLine("Erreur d'ajout du produit");
            }
        }

        private void StartOrderAction()
        {
            order = new Order();
            string choice;
            do
            {
                SubMenu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddProductToOrderAction();
                        break;
                    case "2":
                        if (CardPaymentAction())
                            choice = "0";
                        break;
                    case "3":
                        if (CashPaymentAction())
                            choice = "0";
                        break;
                }
            } while (choice != "0");

        }

        private void AddProductToOrderAction()
        {
            int id;
            do
            {
                Console.Write("Merci de saisir l'id : ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));
            Product product = cashRegistry.GetProductById(id);
            if (product != null)
            {
                if (order.AddProduct(product))
                {
                    Console.WriteLine($"Produit {product.Title} ajouté à la vente");
                }
                else
                {
                    Console.WriteLine("Erreur d'ajout de produit ");
                }
            }
            else
            {
                Console.WriteLine("Aucun produit avec cet id");
            }

        }

        private bool CardPaymentAction()
        {
            Console.WriteLine("Paiement par carte");
            Payment payment = new CardPayment();
            if(cashRegistry.AddOrder(order, payment))
            {
                Console.WriteLine("Paiement CB effectué ");
                return true;
            }
            return false;
        }
        private bool CashPaymentAction()
        {
            Console.WriteLine("Paiement en espèce");
            decimal amount;
            do
            {
                Console.Write("Merci de saisir le montant : ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out amount));
            CashPayment payment = new CashPayment(amount);
            if(cashRegistry.AddOrder(order, payment))
            {
                Console.WriteLine("Paiement espèce effectué " + payment.Change);
                return true;
            }
            return false;
        }
    }
}
