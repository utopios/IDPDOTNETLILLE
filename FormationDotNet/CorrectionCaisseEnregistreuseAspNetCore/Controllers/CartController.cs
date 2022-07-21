using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class CartController : Controller
    {
        private ICart _cartService;

        public CartController(ICart cartService)
        {
            _cartService = cartService;
        }


        public IActionResult Index()
        {
            return View(_cartService.GetOrder());
        }

        public IActionResult AddToCart(int id)
        {
            _cartService.AddProduct(id);
            return RedirectToAction("Index", "CashRegistry", new {search = id});
        }
    }
}
