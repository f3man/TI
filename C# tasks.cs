// #1
public class Program
{
	public static void Main()
  {
    int b = 3;
   	ChangeValue(b, 5);
    Console.WriteLine(b);
  }
  
  public static void ChangeValue(int b, int c)
  {	
    b = c;
  }
}

// #2
public class User
{
   public string Name { get; set; }
}

[ApiController]
public class OrderApiController
{
   public Task<IActionResult> Submit(User user)
   {
   	// ...
   }
}

// #2 List
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var addressList = new AddressRepository().GetAddresses();
		var mapper = new AddressMapper();
		var result = mapper.Map(addressList);
	}
}


public class Address 
{
	public string Country { get; set;}
	public string City { get; set;} 
	public string Region { get; set;} 
	public string StreetAddress { get; set;} 
}

public class AddressDto 
{
	public string Country { get; set; }
	public string City { get; set; }
	public string Region { get; set; }
}

public class AddressRepository 
{
	public List<Address> GetAddresses()
	{
		return new List<Address> {
			new Address { Country = "USA", Region = "California", City = "LA", StreetAddress = "Boston st. 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Ladozka 23" },
			new Address { Country = "Poland", Region = "Lower Silesia", City = "Wroclaw", StreetAddress = "Legnicka 25" },
		};
	}
}

public class AddressMapper 
{
	public List<AddressDto> Map(ICollection<Address> addresses)
	{
		// Implement
		throw new NotImplementedException("I should implement it");
	}
}

// #3
public static class Program
{
	public static void Main()
  {
    var actions = new List<Action>();
    for (var i = 0; i < 5; i++)
    {
      actions.Add(() => {
        Console.WriteLine(i);
      });
    }
    
    foreach (var action in actions)
    {
      action();
    }
  }
}

// #4 
public class Program
{
	public static void Main()
	{
		var addressList = new AddressRepository().GetAddresses();
		var uniqueCities = getUniqueCities(addressList);
	}
	
	private static HashSet<Address> getUniqueCities(List<Address> addresses)
	{
		throw new NotImplementedException("Implement me please");
	}
}



public class Address 
{
	public string Country { get; set;}
	public string City { get; set;} 
	public string Region { get; set;} 
	public string StreetAddress { get; set;} 
}


public class AddressRepository 
{
	public List<Address> GetAddresses()
	{
		return new List<Address> {
			new Address { Country = "USA", Region = "California", City = "LA", StreetAddress = "Boston st. 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Ladozka 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Borodinska 23" },
			new Address { Country = "Poland", Region = "Lower Silesia", City = "Wroclaw", StreetAddress = "Legnicka 25" },
		};
	}
}


// #5
public struct MegaStruct : IDisposable
{
   public void Dispose()
   {
   		// implementation
   }
}

// #6
class Program
{
    private enum MegaEnum
    {
        First = 15,
        Second,
        Third = 54
    }
  
    static void Main()
    {
        Console.WriteLine((int)MegaEnum.Second);
        Console.Read();
    }
}
