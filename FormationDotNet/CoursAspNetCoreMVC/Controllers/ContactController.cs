using AnnuaireEntityFrameWorkCore.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            //
            DataContext _data = new DataContext();
            ViewData["contacts"] = _data.Contacts.ToList();
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
