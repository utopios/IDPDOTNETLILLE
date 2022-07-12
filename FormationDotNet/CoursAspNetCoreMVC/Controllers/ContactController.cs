using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        public string Index()
        {
            return "Acccueil annuaire contact";
        }

        public string Form()
        {
            return "Page formulaire";
        }
        public string DetailContact()
        {
            return "Page détail contact";
        }
    }
}
