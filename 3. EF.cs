
public class AddressRepository
{
    public DbSet<Address> Addresses { get; set; }

    public async Task<List<Address>> GetAddresses()
    {
        var addresses1 = await Addresses.AsQueryable()
            .Where(x => x.Country == "Ukraine");

        var addresses2 = await Addresses.AsEnumerable()
            .Where(x => x.Country == "Moldova");


        var addresses3 = await Addresses.AsEnumerable()
            .Where(x => x.Country == "Serbia");

    }
}