namespace HwEleven
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 5, -2, 5, 1 };

            Console.Write("Original: ");
            PrintArray(numbers);

            Console.Write("Reversed: ");
            PrintArray(ArrayHelper.Reverse(numbers));

            Console.Write("Sorted: ");
            PrintArray(ArrayHelper.Sort(numbers));

            Console.WriteLine("Any (5): " + ArrayHelper.Any(numbers, 5));
            Console.WriteLine("All (5): " + ArrayHelper.All(numbers, 5));

            Console.WriteLine("FirstOrDefault (5): " + ArrayHelper.FirstOrDefault(numbers, 5));
            Console.WriteLine("LastOrDefault (5): " + ArrayHelper.LastOrDefault(numbers, 5));

            Console.Write("FindAll (5): ");
            PrintArray(ArrayHelper.FindAll(numbers, 5));

            Console.WriteLine("FindIndex (5): " + ArrayHelper.FindIndex(numbers, 5));
            Console.WriteLine("FindLastIndex (5): " + ArrayHelper.FindLastIndex(numbers, 5));

            Console.WriteLine("Sum: " + ArrayHelper.Sum(numbers));
        }
    }
}
