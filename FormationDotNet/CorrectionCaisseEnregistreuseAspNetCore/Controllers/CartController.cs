using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
