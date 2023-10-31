public class User
{
   public string Name { get; set; }
   public string LastName { get; set; } = null!;
}

[Route("users")]
[ApiController]
public class UserApiController : ControllerBase
{

    public UserApiController(IRequestHandler requestHandler)
    {
        
    }
    [HttpPost]
    public Task<IActionResult> SearchCustomer([FromBody] Payload payload)
    {
        // 
        // 
        // ...
    }
}

// .NET 5 -> .NET 6

// POST /users
/*

{
    "Name": "John",
    "LastName": null
}  
*/