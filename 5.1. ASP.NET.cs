public class User
{
   public string Name { get; set; }
   public string LastName { get; set; };
}

[Route("users")]
[ApiController]
public class UserApiController : ControllerBase
{

    public UserApiController(IRequestHandler requestHandler)
    {
        
    }
    [HttpPost]
    public Task<IActionResult> SearchCustomer([FromBody] User user)
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