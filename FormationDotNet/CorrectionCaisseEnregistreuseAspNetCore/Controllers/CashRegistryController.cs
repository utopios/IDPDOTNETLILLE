using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionCaisseEnregistreuseAspNetCore.Controllers
{
    public class CashRegistryController : Controller
    {
        private BaseRepository<Product> _productRepository;

        public CashRegistryController(BaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index(string search)
        {
            List<Product> products = new List<Product>();
            if(search != null)
            {
                products = _productRepository.FindAll(p => p.Title.Contains(search) || p.Id.ToString() == search);
            }
            return View(products);
        }
    }
}
