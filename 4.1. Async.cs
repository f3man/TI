public class Program
{
    public void Main()
    {
        var number = GetNumber().Result;
    }

    public Task<int> GetNumber()
    {
        Task.Delay(10000);
        return Task.FromResult(5);
    }
}
