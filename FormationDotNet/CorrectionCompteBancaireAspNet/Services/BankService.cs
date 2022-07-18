using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Repositories;
using BankEntityFrameWork.Tools;

namespace CorrectionCompteBancaireAspNet.Services
{
    public class BankService
    {
        private BaseRepository<Account> _accountRepository;
 

        public BankService(BaseRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;

        }

        public Account AddAccount(Customer customer)
        {


            Account account = new Account(customer, createRandomAccountNumber(5));
            if (_accountRepository.Create(account))
            {
                return account;
            }
            return null;
        }

        public bool MakeWithDraw(decimal amount, int accountNumber)
        {
            //A coder
            Account account = GetAccount(accountNumber);

            if (account != null)
            {
                Operation operation = new Operation(amount);



                return account.WithDraw(operation) && _accountRepository.Update();
            }
            return false;
        }

        public bool MakeDeposit(decimal amount, int accountNumber)
        {
            Account account = GetAccount(accountNumber);
            Operation operation = new Operation(amount);
            return account.Deposit(operation) && _accountRepository.Update();

        }

        public Account GetAccount(int number)
        {
            Account account = _accountRepository.Find(c => c.AccountNumber == number);
            return account;
        }
        private int createRandomAccountNumber(int size)
        {
            string code = "";
            Random r = new Random();
            for (int i = 1; i <= size; i++)
            {
                code += r.Next(0, 10);
            }
            return Convert.ToInt32(code);
        }
    }

    
}
