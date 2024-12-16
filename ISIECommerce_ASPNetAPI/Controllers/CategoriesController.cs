using Microsoft.AspNetCore.Mvc;
using ECommerceWCFService;

namespace ISIECommerce_ASPNetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        /*private readonly ECommerceServiceClient _wcfClient;

        public ProductsController()
        {
            _wcfClient = new ECommerceServiceClient();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _wcfClient.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _wcfClient.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            var result = await _wcfClient.AddProductAsync(product);
            if (result)
            {
                return CreatedAtAction(nameof(GetProductById), new { id = product.ID }, product);
            }
            return BadRequest("Error while adding the product.");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.ID)
            {
                return BadRequest("ID mismatch.");
            }

            var result = await _wcfClient.UpdateProductAsync(product);
            if (result)
            {
                return NoContent();
            }
            return NotFound($"Product with ID {id} not found.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var result = await _wcfClient.DeleteProductAsync(id);
            if (result)
            {
                return NoContent();
            }
            return NotFound($"Product with ID {id} not found.");
        }*/
    }
}
