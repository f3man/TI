// #1
public class Program
{
  public static void Main()
  {
    int b = 3;   
    ChangeValue(b, 5);
    Console.WriteLine(b);

    var entity = new Entity { Number = 3 };
    ChangeNumberInEntity(entity, 5);
    Console.WriteLine(entity.Number);
  }
  
  public static void ChangeValue(int b, int c)
  {	
    b = c;
  }

  public static void ChangeNumberInEntity(Entity entity, int value)
  {
    entity.Number = value;
  }
}

public class Entity
{
  public int Number { get; set; }
}

// 