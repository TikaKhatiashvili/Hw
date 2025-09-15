namespace HwOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. ავტორიზაცია
            string Username = "Test", Pasw = "TestPasw";
            Console.Write("Enter Username : ");
            string uname = Console.ReadLine();

            Console.Write("Enter Paswwoord : ");
            string pw = Console.ReadLine();

            if ((Username == uname) && (Pasw == pw))
            {
                Console.WriteLine($"Is Correct");

            }
            else if ((Username == uname) && (Pasw != pw))
            {
                Console.WriteLine($"Password is InCorrect");
            }
            else if ((Username != uname) && (Pasw != pw))
            {
                Console.WriteLine($"Username and Password is InCorrect");
            }
            else
            {
                Console.WriteLine($"Try Again");
            }

            //2. ქულების მიხედვით შეფასება (Grade Calculator)

            Console.Write("Enter Point 0-100 : ");
            int point = int.Parse(Console.ReadLine());

            if ((point >= 90) && (point <= 100))
            {
                Console.WriteLine($"Your Grade {point} is A+");
            }
            else if ((point >= 80) && (point <= 89))
            {
                Console.WriteLine($"Your Grade {point} is A");
            }
            else if ((point >= 70) && (point <= 79))
            {
                Console.WriteLine($"Your Grade {point} is B");
            }
            else if (point > 100)
            {
                Console.WriteLine($"Your Grade {point} is more than 100, Try again");
            }
            else
            {
                Console.WriteLine($"Your Grade {point} is C or below");
            }

            //3. ფასდაკლების გამოთვლა
            Console.Write("Enter Product Price : ");
            double price = int.Parse(Console.ReadLine());
            double percent;

            double value = (price / 100) * price;

            if (price > 1000)
            {
                percent = 10;

            }
            else
            {
                percent = 5;

            }

            double discount = (price * percent) / 100;
            double finalPrice = price - discount;
            Console.WriteLine($"Your Final Product Price is {finalPrice}");

        }
    }
}
