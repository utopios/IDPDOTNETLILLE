using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "Bonjour je suis la méthode index du controleur produit";
        }
    }
}
