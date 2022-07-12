using CoursAspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoursAspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Voiture v = new Voiture()
            {
                Marque = "Tesla"
            };
            //pour passer des données du controleur vers la vue
            //1 => ViewData
            ViewData["voiture"] = v;
            ViewData["voitures"] = new List<Voiture>() { v, new Voiture() { Marque="Espace" } };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}