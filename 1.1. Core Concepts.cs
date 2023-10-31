// #1
public class Program
{
  public static void Main()
  {
    int b = 3;   
    ChangeValue(b, 5);
    Console.WriteLine(b);
  }
  
  public static void ChangeValue(ref int b, int c)
  {	
    b = c;
  }
}