using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class ProductController : Controller
    {
        private ILogin _loginService;

        public ProductController(ILogin loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            if (_loginService.IsLogged())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
    }
}
