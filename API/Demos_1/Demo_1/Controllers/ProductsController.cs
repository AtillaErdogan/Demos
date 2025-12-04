using Demos_1.Data;
using Demos_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync(); // DBSet<Product> dan veri çekiyor.
            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet("{id}")] // URL de parametre olarak id alır.
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound("Ürün Bulunamadı");

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public  IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing == null)
                return NotFound();

            existing.Name = product.Name;
            existing.Price = product.Price;

            await _context.SaveChangesAsync();

            return Ok(existing);
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing == null)
                return NotFound();

            _context.Products.Remove(existing);
            await _context.SaveChangesAsync();

            return Ok("Silindi");
        }

    }
}
