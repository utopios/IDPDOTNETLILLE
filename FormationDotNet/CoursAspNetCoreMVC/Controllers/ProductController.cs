using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //return new ContentResult() { Content = "<h1>Bonjour je suis la méthode index du controleur produit</h1>", ContentType="text/html" };
            return View();
        }
    }
}
