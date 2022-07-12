using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        public IActionResult DetailContact()
        {
            return View();
        }
    }
}
