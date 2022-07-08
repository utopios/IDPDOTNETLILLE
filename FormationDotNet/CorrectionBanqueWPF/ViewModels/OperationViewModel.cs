
using BankEntityFrameWork.Classes;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CorrectionBanqueWPF.ViewModels
{
    public class OperationViewModel
    {
        private Bank _bank;
        public string Type { get; set; }

        public decimal Amount { get; set; }
        

        public MainViewModel MainViewModel { get; set; }

        public ICommand OperationCommand { get; set; }

        public OperationViewModel(string type, MainViewModel mainViewModel, Bank bank)
        {
            Type = type;
            MainViewModel = mainViewModel;
            OperationCommand = new RelayCommand(OperationAction);
            _bank = bank;
        }

        private void OperationAction()
        {
            bool result = false;
                if (Type == "deposit")
                {
                    if (_bank.MakeDeposit(Amount, MainViewModel.SearchAccount.AccountNumber))
                    {
                        result = true;
                    }
                }
                else if (Type == "withDraw")
                {
                    if (_bank.MakeWithDraw(Amount, MainViewModel.SearchAccount.AccountNumber))
                    {
                        result = true;
                    }
                }
            
            if (result)
            {
                MainViewModel.SearchAccountAction();
            }
        }
    }
}
