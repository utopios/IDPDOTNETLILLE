using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CorrectionCaisseEnregistreuseAspNetCore.Interfaces;
using Newtonsoft.Json;

namespace CorrectionCaisseEnregistreuseAspNetCore.Services
{
    public class CartSessionService : ICart
    {
        private IHttpContextAccessor _httpContextAccessor;
        private BaseRepository<Product> _productRepository; 

        public CartSessionService(IHttpContextAccessor httpContextAccessor, BaseRepository<Product> productRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _productRepository = productRepository;
        }

        public int TotalProducts => GetOrder().Products.Count;

        public bool AddProduct(int productId)
        {
            Order order = GetOrder();
            if(order.AddProduct(_productRepository.Find(p => p.Id == productId)))
            {
                _httpContextAccessor.HttpContext.Session.SetString("order", JsonConvert.SerializeObject(order));
                return true;
            }
            return false;
        }

        public Order GetOrder()
        {
            Order order = new Order();
            string orderString = _httpContextAccessor.HttpContext.Session.GetString("order");
            try
            {
                order = JsonConvert.DeserializeObject<Order>(orderString);
            }catch(Exception ex)
            {

            }
            return order;
        }

        public bool RemoveProduct(int productId)
        {
            Order order = GetOrder();
            if (order.DeleteProduct(order.Products.FirstOrDefault(p => p.Product.Id == productId)))
            {
                _httpContextAccessor.HttpContext.Session.SetString("order", JsonConvert.SerializeObject(order));
                return true;
            }
            return false;
        }
    }
}
