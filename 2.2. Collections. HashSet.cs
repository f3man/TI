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
	public string StreetAddress { get; set;} //not interested
}


public class AddressRepository 
{
	public List<Address> GetAddresses()
	{
		return new List<Address> {
			new Address { Country = "USA", Region = "California", City = "LA", StreetAddress = "Boston st. 23" },
			new Address { Country = "USA", Region = "New York", City = "New York", StreetAddress = "Boston st. 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Ladozka 23" },
			new Address { Country = "Ukraine", Region = "Zaporizka", City = "Zaporizhia", StreetAddress = "Borodinska 23" },
			new Address { Country = "Ukraine", Region = "Donetska", City = "New York", StreetAddress = "Boston st. 23" },
			new Address { Country = "Poland", Region = "Lower Silesia", City = "Wroclaw", StreetAddress = "Legnicka 25" },
		};
	}
}
