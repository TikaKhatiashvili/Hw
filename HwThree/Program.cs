namespace HwThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region დავალება 1

            try
            {
                Console.Write("Enter Number: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number!");
            }

            #endregion

            #region დავალება 2

            Console.Write("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine($"Even numbers from {a} to {b}:");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            #endregion

            #region დავალება 3

            try
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Division by zero is not allowed!");
                        }
                        result = num1 / num2;
                        break;

                    default:
                        throw new InvalidOperationException("Invalid operator!");
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculator finished.");
            }
            #endregion
        }
    }
}
