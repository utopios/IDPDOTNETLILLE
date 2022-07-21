using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class UserController : Controller
    {
        private ILogin _login;

        public UserController(ILogin login)
        {
            _login = login;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitLogin(string username, string password)
        {
            if(_login.Login(username, password))
            {
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Login");
        }
    }
}
