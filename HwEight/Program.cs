using HwEight.Medium;
using HwEight.Simple;

namespace HwEight
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Simple
            try
            {
                Animal[] animals =
                {
                    new Dog("Dogname"),
                    new Cat("Catname"),
                    new Dog("")
                };

                foreach (var animal in animals)
                {
                    animal.MakeSound();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
            #endregion

            #region Medium
            static void Main(string[] args)
            {
                var checking1 = new CheckingAccount("CHK-1001", 500m);
                var checking2 = new CheckingAccount("CHK-1002", 200m);
                var loan1 = new LoanAccount("LN-2001", 1000m); 

                var transactionService = new TransactionService();

                try
                {
                    Console.WriteLine("Accounts before transactions:");
                    Console.WriteLine(checking1);
                    Console.WriteLine(checking2);
                    Console.WriteLine(loan1);
                    Console.WriteLine();

                    transactionService.Transfer(checking1, checking2, 150m);

                    transactionService.Transfer(checking2, loan1, 100m);

                    transactionService.Transfer(checking2, loan1, 500m);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Final Account Status:");
                    Console.WriteLine(checking1);
                    Console.WriteLine(checking2);
                    Console.WriteLine(loan1);
                }
            }
            #endregion

        }
    }
}
