
    public void DoSomething()
    {
        var sourceList =  new List<OrderDb>();
        var targetList = new List<OrderDto>();

        foreach (var source in sourceList)
        {
            // do mapping
            targetList.Add(new OrderDto()); 
        }
    }


    public class OrderDb {}
    public class OrderDto