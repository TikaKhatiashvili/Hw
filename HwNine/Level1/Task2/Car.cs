namespace HwNine.Level1.Task2;

public class Car : IVehicle
{
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine($"The {Year} {Model} is starting...");
    }
}