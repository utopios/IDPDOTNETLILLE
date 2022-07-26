using ApiCashRegistry.Services;
using ApiCashRegistry.Tools;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCashRegistry.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [EnableCors("allRequestOnlyGetVerb")]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.GetProduct(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpPost]
        public IActionResult Post([FromBody]ProductRequestDTO productDTO)
        {
            return Ok(_productService.AddProduct(productDTO));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return StatusCode(500);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return StatusCode(500);
        }

    }
}
