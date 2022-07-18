using CoursAspIOC.Models;
using CoursAspIOC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoursAspIOC.Controllers
{
    public class HomeController : Controller
    {

        private ServiceA _serviceA;

        private ServiceB _serviceB;

        public HomeController(ServiceA serviceA, ServiceB serviceB)
        {
            _serviceA = serviceA;
            _serviceB = serviceB;
        }

        public IActionResult Index()
        {
            ViewBag.ValServiceA = "Val Service A " + _serviceA.GetValue;
            ViewBag.ValServiceB = "Val Service B " + _serviceB.GetValue;
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