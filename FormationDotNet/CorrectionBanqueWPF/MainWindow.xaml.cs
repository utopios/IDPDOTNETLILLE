
using BankEntityFrameWork.Classes;
using CorrectionBanqueWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CorrectionBanqueWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bank bank;
        private Account searchAccount;
        public MainWindow()
        {
            InitializeComponent();
            bank = new Bank("wpf bank");
            DataContext = new MainViewModel();
            //CreateAccountButton.Click += CreateAccountClick;
            //SearchAccountButton.Click += SearchAccountClick;
        }

        //private void CreateAccountClick(object sender, RoutedEventArgs eventArgs)
        //{
        //    decimal initialAmount;
        //    Customer customer = new Customer(PhoneTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text);
        //    Account account = bank.AddAccount(customer);
        //    if(account != null)
        //    {
        //        if(decimal.TryParse(InitialAmountTextBox.Text, out initialAmount))
        //        {
        //            bank.MakeDeposit(initialAmount, account.AccountNumber);
        //        }
        //        MessageBox.Show("Compte crée avec le numéro de compte : "+account.AccountNumber);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erreur création de compte");
        //    }
        //    PhoneTextBox.Text = "";
        //    FirstNameTextBox.Text = "";
        //    LastNameTextBox.Text = "";
        //    InitialAmountTextBox.Text = "";
        //}

        //private void SearchAccountClick(object sender, RoutedEventArgs eventArgs)
        //{
        //    int number;
        //    if(int.TryParse(AccountNumberTextBox.Text, out number))
        //    {
        //        searchAccount = bank.GetAccount(number);
        //        if(searchAccount != null)
        //        {
        //            ResultCustomerLabel.Content = searchAccount.Customer.ToString();
        //            TotalAmountLabel.Content = searchAccount.TotalAmount;
        //            OperationsListView.ItemsSource = searchAccount.Operations;
        //        }
        //        else
        //        {
        //            MessageBox.Show("aucun compte avec ce numéro");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Merci de saisir un numéro !!!!!!");
        //    }
        //}

        //private void DepositClick(object sender, RoutedEventArgs eventArgs)
        //{
        //    if(searchAccount != null)
        //    {
        //        OperationWindow window = new OperationWindow(searchAccount, "deposit", OperationsListView, TotalAmountLabel, bank);
        //        window.Show();

        //    }
        //}
        //private void WithDrawClick(object sender, RoutedEventArgs eventArgs)
        //{
        //    if (searchAccount != null)
        //    {
        //        OperationWindow window = new OperationWindow(searchAccount, "withDraw", OperationsListView, TotalAmountLabel, bank);
        //        window.Show();

        //    }
        //}
    }
}
