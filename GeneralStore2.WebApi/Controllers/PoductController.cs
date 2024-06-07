using GeneralStoreApi2.Data;
using Microsoft.AspNetCore.Mvc;
using GeneralStore2Api.Models;


namespace GeneralStore2.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly GeneralStore2DbContext _context;
    public ProductController(GeneralStore2DbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductAsync(ProductRequest request)
    {
        ProductController newProduct = new()
        {
            Name = request.Name,
            Price = request.Price,
            QuantityInStock = request.QuantityInStock
        };

        _context.Products.Add(newProduct);
        await _context.SaveChangesAsync();

        return Ok(newProduct);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProductsAsync()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }
}
