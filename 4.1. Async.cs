public class Program
{
    public void Main()
    {
        var number = GetNumber().Result;
    }

    public async Task GetAsync()
    {
        var number1 = await GetNumber1();
        var number2 = await GetNumber2();

        Console.WriteLine(number1);
        Console.WriteLine(number2); 
    }

    public Task<int> GetNumber1()
    {
        return getNumberFromDb();
    }

    public async Task<int> GetNumber2()
    {
        return await getNumberFromDb();
    }

    private Task<int> getNumberFromDb()
    {
        return Task.Run(() => 5);
    }


}


public class AddressRepository
{
    public DbSet<Address> Addresses { get; set; }

    public async Task<List<Address>> GetAddresses()
    {
        var addresses1 = await Addresses.AsQueryable()
            .Where(x => x.Country == "Ukraine");

        var addresses2 = await Addresses.AsEnumerable()
            .Where(x => x.Country == "Moldova");

    }
}