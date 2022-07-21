using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
