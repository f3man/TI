
// #3
public static class Program
{
    public static void Main()
    {
        var actions = new List<Action>();
        for (var i = 0; i < 5; i++)
        {
            
            actions.Add(() => {
                Console.WriteLine(i); // 
            });
        }
        foreach (var action in actions)
        {
            action();
        }
    }
}