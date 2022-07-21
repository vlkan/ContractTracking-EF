using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    [HttpGet]
    public List<Customer> Get() 
    {
        return new List<Customer>();
    }
}
