public class Program
{
    public void Main()
    {
        var number = GetNumber().Result;
    }


    public async Task<int> GetNumber()
    {
        // some code here
        throw new NotImplementedException();
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