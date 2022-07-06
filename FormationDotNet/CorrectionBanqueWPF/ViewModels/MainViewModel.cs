﻿using CompteBancaireAdoNet.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CorrectionBanqueWPF.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        private Bank bank;
        public Account Account { get; set; }

        public Customer Customer { get => Account.Customer; set => Account.Customer = value; }

        public string FirstName { get => Customer.FirstName; set => Customer.FirstName = value; }

        public string LastName { get => Customer.LastName; set => Customer.LastName = value; }

        public string Phone { get => Customer.Phone; set => Customer.Phone = value; }

        public decimal InitialAmount { get; set; }


        public ICommand CreateAccountCommand { get; set; }
        public MainViewModel()
        {
            Account = new Account();
            Account.Customer = new Customer();
            bank = new Bank("bp");
            CreateAccountCommand = new RelayCommand(CreateAccountAction);
        }

        private void CreateAccountAction()
        {
            Account = bank.AddAccount(Customer);
            if (Account != null)
            {
                bank.MakeDeposit(InitialAmount, Account.AccountNumber);
                MessageBox.Show("Compte crée avec le numéro de compte : " + Account.AccountNumber);
            }
            else
            {
                MessageBox.Show("Erreur création de compte");
            }
        }
    }
}
