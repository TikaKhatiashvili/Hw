namespace HwFourr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region მასივის შებრუნება

            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array in reverse:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            #endregion

            #region ელემენტის ძებნა მასივში

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.Write("Enter numbers: ");
            //int n = int.Parse(Console.ReadLine());

            //bool found = false;
            //foreach (var num in numbers)
            //{
            //    if (num == n)
            //    {
            //        found = true;
            //        break;
            //    }

            //}
            //Console.WriteLine(found ? "Number found!" : "Number not found!");

            #endregion

            #region მასივის კოპირება

            int[] orig = { 1, 2, 3, 4, 5 };
            int[] copy = new int[orig.Length];

            for (int i = 0; i < orig.Length; i++)
            {
                copy[i] = orig[i];
            }

            Console.WriteLine("Copied :");
            foreach (var num in copy)
            {
                Console.Write(num + " ");
            }

            #endregion

            #region მეორე უდიდესი რიცხვი 

            //int[] numbers = { 10, 20, 5, 40, 30 };

            //int largest = numbers[0];
            //int secondLargest = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = numbers[i];
            //    }
            //    else if (numbers[i] > secondLargest && numbers[i] != largest)
            //    {
            //        secondLargest = numbers[i];
            //    }
            //}

            //Console.WriteLine($"Second largest: {secondLargest}");


            #endregion

            //#region ელემენტების სიხშირე
            //int[] numbers = { 1, 2, 2, 3, 1, 4, 2 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    bool alreadyPrinted = false;
            //    for (int k = 0; k < i; k++)
            //    {
            //        if (numbers[i] == numbers[k])
            //        {
            //            alreadyPrinted = true;
            //            break;
            //        }
            //    }

            //    if (!alreadyPrinted)
            //    {
            //        int count = 0;
            //        for (int j = 0; j < numbers.Length; j++)
            //        {
            //            if (numbers[i] == numbers[j])
            //                count++;
            //        }

            //        Console.WriteLine(numbers[i] + " => " + count);
            //    }
            //}

            //#endregion


            #region დუბლიკატების წაშლა

            int[] arr = { 1, 2, 2, 3, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                    if (arr[i] == arr[k])
                        alreadyPrinted = true;

                if (!alreadyPrinted)
                    Console.WriteLine(arr[i]);
            }

            #endregion


        }
    }
}
