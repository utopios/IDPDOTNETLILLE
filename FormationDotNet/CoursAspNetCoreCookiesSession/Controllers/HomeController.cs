using CoursAspNetCoreCookiesSession.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CoursAspNetCoreCookiesSession.Controllers
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
            //var options = new CookieOptions()
            //{
            //    Expires = DateTime.Now.AddDays(1)
            //};
            //HttpContext.Response.Cookies.Append("key-cookie", "value of cookie", options);
            List<string> liste = new List<string>() { "toto", "tata", "titi" };
            HttpContext.Session.SetString("key-session", "value-session");
            HttpContext.Session.SetString("liste", JsonConvert.SerializeObject(liste));
            return View();
        }

        public IActionResult Privacy()
        {
            //string value = HttpContext.Request.Cookies["key-cookie"];
            string value = HttpContext.Session.GetString("key-session");
            string chaine = HttpContext.Session.GetString("liste");
            List<string> liste = JsonConvert.DeserializeObject<List<string>>(chaine);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}