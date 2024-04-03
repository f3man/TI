public void Program
{
    public void Main()
    {
        var garage = new Dictionary<ParkingSpaceKey, Car>();

        garage[new ParkingSpaceKey(1, 5)] = new Car("Hyundai", "Accent", "AP8844CK");
        garage[new ParkingSpaceKey(2, 13)] = new Car("KIA", "Ceed", "BC2341PB");
        garage[new ParkingSpaceKey(3, 17)] = new Car("Hyundai", "Accent", "AC3214EB");


        //

        var hammer = new Car("Hammer", "H1", "HC4433CC");
        var parkingSpace = new ParkingSpaceKey(3, 17);
        if (garage.ContainsKey(parkingSpace)) 
        {
            Console.WriteLine("This parking space is busy");
        } else {
            garage.Add(parkingSpace, hammer);
            Console.WriteLine("This parking space is available");
        }
    }


}

public class ParkingSpaceKey {

    public int Floor { get; private set; }
    public int ParkingSpace {get; private set; }

    public ParkingSpaceKey(int floor, int parkingSpace)
    {
        Floor = floor;
        ParkingSpace = parkingSpace;
    }
}

public class Car
{
    public string Model { get; private set; }
    public string Make { get; private set;}
    public string LicenseNumber { get; private set; }

    public Car(string make, string model, string licenseNumber)
    {
        Make = make;
        Model = model;
        LicenseNumber = licenseNumber;
    }
}