using Microsoft.AspNetCore.Mvc;

namespace CorrectionPetiteAnnonce.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
