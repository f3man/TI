
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

// #1

public static class Program
{
	public static Main()
  {
    var actions = new List<Action>();
    for (var i = 0; i < 5; i++)
    {
      actions.Add(() => {
        Console.WriteLine(i);
      });
    }
    
    foreach (var actions in actions)
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
    var uniqueAddresses = new HashSet<Address>(new AddressUniqueCityComparer());
    
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
			new Address { Country = "USA", Region = "New York", City = "NY", StreetAddress = "Wall St. 23" },
			new Address { Country = "Ukraine", Region = "Donetska", City = "NY", StreetAddress = "Peremogy St. 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Ladozka 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Borodinska 23" },
			new Address { Country = "Poland", Region = "Lower Silesia", City = "Wroclaw", StreetAddress = "Legnicka 25" },
		};
	}
}
