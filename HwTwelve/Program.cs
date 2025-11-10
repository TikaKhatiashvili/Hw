using System.Text.Json;

namespace HwTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"../../../cars.json";
            string jsondata = File.ReadAllText(path);

            List<Vehicle>? vehicles = JsonSerializer.Deserialize<List<Vehicle>>(jsondata);
            string x = JsonSerializer.Serialize(vehicles);
        }
    }
}
