using ApiCashRegistry.Tools;
using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;
using CashRegistryEntityFrameWork.Tools;

namespace ApiCashRegistry.Services
{
    public class OrderService
    {
        private BaseRepository<Order> _orderRepository;
        private BaseRepository<Product> _productRepository;


        public OrderService(BaseRepository<Order> orderRepository, BaseRepository<Product> productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            
        }

        public OrderResponseDTO AddOrder(OrderRequestDTO orderRequestDTO)
        {
            Order order = new Order();
            CardPayment payment = new CardPayment();            
            order.Payment = payment;
            payment.Payment = order.Payment;
            foreach(int i in orderRequestDTO.ProductsId)
            {
                order.AddProduct(_productRepository.Find(p => p.Id == i));
            }
            _orderRepository.Create(order);
            return new OrderResponseDTO(order.Id, order.Total);
        } 
    }
}
