public struct MegaStruct : IDisposable
{
    public void Dispose()
    {

    }
}

public struct S : IDisposable
{
    private bool dispose;
    public void Dispose()
    {
        dispose = true;
    }
    public bool GetDispose()
    {
        return dispose;
    }
}

#region Example

public class Program
{
    public static void Main()
    {
        var s = new S();
        using (s)
        {
            Console.WriteLine(s.GetDispose());
        }
        Console.WriteLine(s.GetDispose());
    }
}
#endregion