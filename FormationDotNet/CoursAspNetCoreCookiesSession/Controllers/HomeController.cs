using CoursAspNetCoreCookiesSession.Models;
using Microsoft.AspNetCore.Mvc;
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
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1)
            };
            HttpContext.Response.Cookies.Append("key-cookie", "value of cookie", options);
            return View();
        }

        public IActionResult Privacy()
        {
            string value = HttpContext.Request.Cookies["key-cookie"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}