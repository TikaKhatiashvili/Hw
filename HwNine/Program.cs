using HwNine.Counter;
using HwNine.Counter.Guns;
using HwNine.Level1.Task1;
using HwNine.Level1.Task2;
using HwNine.Level2.Task4;
using HwNine.Level2.Task5;
using HwNine.Level2.Task6;
using System.Reflection.Metadata;

namespace HwNine
{
    internal class Program
    {
        static void Main(string[] args) // 5 და 6 დავალბა გამიჭირდა, ai დავიხმარიე თუმცა ვიზრებ პროცესს
        {
            #region Task 1

            List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat()
            };
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            #endregion

            #region Task 2

            Car myCar = new Car
            {
                Model = "Ford Focus",
                Year = 2018
            };

            myCar.Start();

            #endregion

            #region Task 3

            Level1.Task3.Document document = new Level1.Task3.Document();
            document.Read();
            document.Write();

            #endregion

            #region Task 4

            IPaymentProcessor processor = null;
            decimal amount = 0;

            try
            {
                while (processor == null)
                {
                    Console.Write("enter payment method (credit or paypal): ");
                    string method = Console.ReadLine()?.Trim().ToLower();

                    switch (method)
                    {
                        case "credit":
                            processor = new CreditCardPayment();
                            break;
                        case "paypal":
                            processor = new PayPalPayment();
                            break;
                        default:
                            Console.WriteLine("invalid payment method. ilease try again.\n");
                            break;
                    }
                }

                bool validAmount = false;
                while (!validAmount)
                {
                    Console.Write("rnter amount: ");
                    string input = Console.ReadLine();

                    if (decimal.TryParse(input, out amount) && amount > 0)
                    {
                        validAmount = true;
                    }
                    else
                    {
                        Console.WriteLine("invalid amount. enter a positive number.\n");
                    }
                }

                processor.ProcessPayment(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\ntrransaction process completed.");
            }

            #endregion

            #region Task 5

            ILogger logger = new ConsoleLogger();

            Console.WriteLine("Testing Log():");
            logger.Log("Simple message");

            Console.WriteLine("\nTesting LogWithTime() :");
            logger.LogWithTime("Log message with timestamp");
            #endregion

            #region Task 6 

            List<IShape> shapes = new List<IShape>
        {
            new Rectangle(5, 10),
            new Circle(3),
            new Rectangle(2, 4)
        };

            double totalArea = 0;

            foreach (var shape in shapes)
            {
                double area = shape.GetArea();
                Console.WriteLine($"Shape area: {area:F2}");
                totalArea += area;
            }

            Console.WriteLine($"\nTotal area of all shapes: {totalArea:F2}");
            #endregion


            #region Lessoncoding
            while (true)
            {
                try
                {
                    Player player = new Player("John", 3000);
                    Shop shop = new Shop();
                    shop.ShowWeapons();
                    Console.WriteLine("Enter the name of the weapon you want to buy:");
                    string weaponName = Console.ReadLine();
                    Weapon weapon = shop.GetWeapon(weaponName);
                    if (weapon == null)
                        Console.WriteLine("Weapon not found in the shop.");
                    string shootweapen = Console.ReadLine();
                    player.UseWeapon(shootweapen);



                }
                catch (Exception ex)
                {

                    Console.WriteLine($"eerror : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Game Ended");
                }

            }
            #endregion
        }
    }
}
