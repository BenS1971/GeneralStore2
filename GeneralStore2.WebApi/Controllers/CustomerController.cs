//using GeneralStoreApi2.Data;
using Microsoft.AspNetCore.Mvc;
//using GeneralStore2Api.Models;

namespace GeneralStore2.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly GeneralStore2DbContext _context;
    public CustomerController(GeneralStore2DbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomerAsync([FromForm] CustomerEdit newCustomer)
    {
        Customer customer = new Customer(){
            Name = newCustomer.Name,
            Email = newCustomer.Email
        };

        _context.Customers.Add(customer);
        await _context.SaveChangesASync();
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCustomersAsync()
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(customers);
    }
}