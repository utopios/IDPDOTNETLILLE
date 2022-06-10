using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCompteBancaire.Classes
{
    class BankIHM
    {
        private Bank bank;

        public void Start()
        {
            //Création de la banque
            Console.Write("Merci de saisir le nom de la banque : ");
            string name = Console.ReadLine();
            bank = new Bank(name);
            Console.Clear();
            string choice;
            do
            {
                Menu();
                choice = Console.ReadLine();
                Console.Clear();
                switch(choice)
                {
                    case "1":
                        CreateAccountAction();
                        break;
                    case "2":
                        MakeDepositAction();
                        break;
                    case "3":
                        MakeWithDrawAction();
                        break;
                    case "4":
                        DisplayBankAccountAction();
                        break;
                }
            } while (choice != "0");
        }

        private void Menu()
        {
            Console.WriteLine("1-- Créer un compte");
            Console.WriteLine("2-- Effectuer un dépôt");
            Console.WriteLine("3-- Effectuer un retrait");
            Console.WriteLine("4-- Afficher les opérations d'un compte");
            Console.WriteLine("0-- Quitter");
        }

        public void CreateAccountAction()
        {
            Customer customer = CreateCustomer();
            if(customer != null)
            {
                Account account = bank.AddAccount(customer);
                if(account != null)
                {
                    GreenColor($"Compte créé avec le numéro {account.AccountNumber}");
                }
                else
                {
                    RedColor("Erreur de création de compte");
                }
            }
            else
            {
                RedColor("Erreur de création de client");
            }
        }

        public void MakeWithDrawAction()
        {

        }

        public void MakeDepositAction()
        {

        }

        public void DisplayBankAccountAction()
        {

        }

        private Account GetAccountAction()
        {
            return null;
        }

        private Customer CreateCustomer()
        {
            Console.Write("Merci de saisir votre nom : ");
            string lastName = Console.ReadLine();
            Console.Write("Merci de saisir votre prénom : ");
            string firstName = Console.ReadLine();
            Console.Write("Merci de saisir votre téléphone: ");
            string phone = Console.ReadLine();
            Customer customer = new Customer(phone, firstName, lastName);
            return customer;
        }

        private void RedColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void GreenColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
