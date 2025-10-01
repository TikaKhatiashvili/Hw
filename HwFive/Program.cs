using System;

namespace HwFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomArray(5);

            PrintArray("Original array:", numbers);

            int[] reversed = ReverseArray(numbers);
            PrintArray("Reversed array:", reversed);

            var result = SearchElement(numbers, 3);
            if (result.found)
                Console.WriteLine($"Number found at index: {result.index}");
            else
                Console.WriteLine("Number not found!");

            int[] copy = CopyArray(numbers);
            PrintArray("Copied array:", copy);

            int secondLargest = FindSecondLargest(numbers);
            Console.WriteLine($"Second largest number: {secondLargest}");

            CountFrequencies(numbers);

            int[] unique = RemoveDuplicates(numbers);
            PrintArray("Array without duplicates:", unique);
        }

        static int[] GenerateRandomArray(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
            return arr;
        }

        static int[] ReverseArray(int[] numbers)
        {
            int[] reversed = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];
            }
            return reversed;
        }

        static (bool found, int index) SearchElement(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                    return (true, i);
            }
            return (false, -1);
        }

        static int[] CopyArray(int[] numbers)
        {
            int[] copy = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
            }
            return copy;
        }

        static int FindSecondLargest(int[] numbers)
        {
            int max = numbers[0];
            int secondMax = int.MinValue;

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
            return secondMax;
        }

        static void CountFrequencies(int[] numbers)
        {
            Console.WriteLine("Frequencies:");
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
                            count++;
                    }
                    Console.WriteLine($"{numbers[i]} = {count}");
                }
            }
        }

        static int[] RemoveDuplicates(int[] numbers)
        {
            int[] temp = new int[numbers.Length];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool exists = false;

                for (int j = 0; j < index; j++)
                {
                    if (numbers[i] == temp[j])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[index] = numbers[i];
                    index++;
                }
            }

            int[] unique = new int[index];
            for (int i = 0; i < index; i++)
            {
                unique[i] = temp[i];
            }

            return unique;
        }

        static void PrintArray(string message, int[] arr)
        {
            Console.Write(message + " ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
