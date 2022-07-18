using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Repositories;
using BankEntityFrameWork.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCompteBancaireAspNet.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitCreateAccount(Account  account, Customer customer)
        {
            //AccountRepository accountRepository = new AccountRepository(new DataContext());
            return RedirectToAction("Index");
        }
    }
}
