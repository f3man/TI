public class Customer
{
   public string Name { get; set; }
   public string LastName { get; set; };
}

[Route("customers")]
[ApiController]
public class CustomerApiController : ControllerBase
{
    [HttpPost]
    [Route("search")]
    public Task<IActionResult> SearchCustomer([FromBody] Customer customer)
    {
        return Ok(customer.Name);
        // 
        // 
        // ...
    }
}

// .NET 5 -> .NET 6

// POST /customers/search
/*

{
    "Name": "John",
    "LastName": null
}  
*/