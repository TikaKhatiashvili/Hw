namespace HwFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 10, 20, 5, 40, 30 };
            int[] numbers3 = { 1, 2, 2, 3, 1, 4, 2 };
            int[] arr = { 1, 2, 2, 3, 1 };

            ReverseArray(numbers1);
            SearchElement(numbers1);
            CopyArray(numbers1);
            FindSecondLargest(numbers2);
            CountFrequencies(numbers3);
            RemoveDuplicates(arr);
        }

        static void ReverseArray(int[] numbers)
        {
            Console.WriteLine("Reversed array:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static void SearchElement(int[] numbers)
        {
            Console.Write("Enter a number to search: ");
            int n = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Number found!");
            else
                Console.WriteLine("Number not found!");
        }

        static void CopyArray(int[] numbers)
        {
            int[] copy = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
            }

            Console.WriteLine("Copied array:");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i] + " ");
            }
            Console.WriteLine();
        }

        static void FindSecondLargest(int[] numbers)
        {
            int max = numbers[0];
            int secondMax = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    secondMax = max;
                    max = numbers[i];
                }
                else if (numbers[i] > secondMax && numbers[i] != max)
                {
                    secondMax = numbers[i];
                }
            }

            Console.WriteLine("Second largest number: " + secondMax);
        }

        static void CountFrequencies(int[] numbers)
        {
            Console.WriteLine("Element frequencies:");
            for (int i = 0; i < numbers.Length; i++)
            {
                bool alreadyCounted = false;

                for (int k = 0; k < i; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (!alreadyCounted)
                {
                    int count = 0;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == numbers[i])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(numbers[i] + " = " + count);
                }
            }
        }

        static void RemoveDuplicates(int[] numbers)
        {
            Console.WriteLine("Array without duplicates:");
            for (int i = 0; i < numbers.Length; i++)
            {
                bool alreadyPrinted = false;

                for (int k = 0; k < i; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }

                if (!alreadyPrinted)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}