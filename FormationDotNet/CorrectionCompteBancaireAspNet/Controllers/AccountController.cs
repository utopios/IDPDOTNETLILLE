using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Repositories;
using BankEntityFrameWork.Tools;
using CorrectionCompteBancaireAspNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCompteBancaireAspNet.Controllers
{
    public class AccountController : Controller
    {
        private BankService _bankService;
        public AccountController(BankService bankService)
        {
            _bankService = bankService;
        }
        public IActionResult Index(string Search, string Message, string Type)
        {
            Account account = null;
            int accountNumber;
            if(Search != null && int.TryParse(Search, out accountNumber))
            {
                account = _bankService.GetAccount(accountNumber);
            }
            ViewBag.Message = Message;
            ViewBag.Type = Type;
            return View(account);
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult SubmitCreateAccount([Bind("FirstName, LastName, Phone")]Customer customer)
        {
            //AccountRepository accountRepository = new AccountRepository(new DataContext());
            Account account = _bankService.AddAccount(customer);
            object data;
            if(account == null)
            {
                data = new { Message = "Erreur de création de compte", Type = "alert-danger" };
            }
            else
            {
                data = new { Message = "Compte crée avec numéro "+account.AccountNumber, Type = "alert-success" };
            }
            return RedirectToAction("Index", data);
        }
    }
}
