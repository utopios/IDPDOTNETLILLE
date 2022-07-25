using ApiCashRegistry.Services;
using ApiCashRegistry.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCashRegistry.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderRequestDTO orderRequestDTO)
        {
            return Ok(_orderService.AddOrder(orderRequestDTO));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_orderService.GetOrder(id));
        }
    }
}
