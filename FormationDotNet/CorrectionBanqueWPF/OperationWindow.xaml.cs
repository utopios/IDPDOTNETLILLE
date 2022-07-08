
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
using System.Windows.Shapes;

namespace CorrectionBanqueWPF
{
    /// <summary>
    /// Logique d'interaction pour OperationWindow.xaml
    /// </summary>
    public partial class OperationWindow : Window
    {
        //private Account _account;
        //private string _type;
        //private ListView _listView;
        //private Label _totalAmountLabel;
        //private Bank _bank;
        public OperationWindow()
        {
            InitializeComponent();
        }


        public OperationWindow(string type, MainViewModel mainViewModel, Bank bank):this()
        {
            DataContext = new OperationViewModel(type, mainViewModel, bank);
        }
        //public OperationWindow(Account account, string type, ListView listView, Label totalAmountLabel, Bank bank) : this()
        //{
        //    _account = account;
        //    _type = type;
        //    _listView = listView;
        //    _totalAmountLabel = totalAmountLabel;
        //    AccountNumberLabel.Content = _account.AccountNumber;
        //    Title += " " + type;
        //    _bank = bank;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    decimal amount;
        //    bool result = false;
        //    if(decimal.TryParse(AmountTextBox.Text, out amount))
        //    {
        //        if(_type== "deposit")
        //        {
        //            if(_bank.MakeDeposit(amount, _account.AccountNumber))
        //            {
        //                result = true;
        //            }
        //        }
        //        else if(_type == "withDraw")
        //        {
        //            if(_bank.MakeWithDraw(amount, _account.AccountNumber))
        //            {
        //                result = true;
        //            }
        //        }
        //    }
        //    if(result)
        //    {
        //        _account = _bank.GetAccount(_account.AccountNumber);
        //        _listView.ItemsSource = _account.Operations;
        //        _totalAmountLabel.Content = _account.TotalAmount;
        //        Close();
        //    }
        //}
    }
}
