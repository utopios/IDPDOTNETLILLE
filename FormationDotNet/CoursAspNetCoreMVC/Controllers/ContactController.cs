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
            //ViewData["contacts"] = _data.Contacts.ToList();
            //ViewBag.contacts = _data.Contacts.ToList();
            return View(_data.Contacts.ToList());
        }

        public IActionResult Form()
        {
            return View();
        }
        public IActionResult DetailContact(int id)
        {
            DataContext _data = new DataContext();
            return View(_data.Contacts.Find(id));
        }
    }
}
