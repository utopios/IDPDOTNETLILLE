using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class CashRegistryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
