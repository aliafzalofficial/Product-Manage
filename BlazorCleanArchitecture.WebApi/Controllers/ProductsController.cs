using BlazorCleanArchitecture.Application.IServices;
using BlazorCleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _service.GetProductById(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (product == null)
            {
                return BadRequest("Product is required.");
            }

            if (string.IsNullOrEmpty(product.Name) || string.IsNullOrEmpty(product.Description) || product.Price <= 0 || product.Quantity < 0)
            {
                return BadRequest("Invalid product data.");
            }

            _service.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product is required.");
            }

            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch.");
            }

            var existingProduct = _service.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound("Product not found.");
            }

            _service.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _service.GetProductById(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            _service.DeleteProduct(id);
            return NoContent();
        }
    }
}