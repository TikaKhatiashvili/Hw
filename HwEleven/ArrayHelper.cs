using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwEleven;

public delegate int[] ArrayOperation(int[] numbers);
public delegate bool BoolOperation(int[] numbers, int value);
public delegate int IntOperation(int[] numbers);
public delegate int[] FindOperation(int[] numbers, int value);
public delegate int FindIndexOperation(int[] numbers, int value);
public delegate int? NullableFindOperation(int[] numbers, int value); 

public class ArrayHelper
{
    // Reverse 
    public static ArrayOperation Reverse = numbers =>
    {
        int[] reversed = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
            reversed[i] = numbers[numbers.Length - 1 - i];
        return reversed;
    };

    // Sort 
    public static ArrayOperation Sort = numbers =>
    {
        int[] sorted = (int[])numbers.Clone();
        Array.Sort(sorted);
        return sorted;
    };

    // Any 
    public static BoolOperation Any = (numbers, value) =>
    {
        foreach (var n in numbers)
            if (n == value) return true;
        return false;
    };

    // All 
    public static BoolOperation All = (numbers, value) =>
    {
        foreach (var n in numbers)
            if (n != value) return false;
        return true;
    };

    // FirstOrDefault 
    public static NullableFindOperation FirstOrDefault = (numbers, value) =>
    {
        foreach (var n in numbers)
            if (n == value) return n;
        return default;
    };

    // LastOrDefault 
    public static NullableFindOperation LastOrDefault = (numbers, value) =>
    {
        for (int i = numbers.Length - 1; i >= 0; i--)
            if (numbers[i] == value) return numbers[i];
        return default;
    };

    // FindAll 
    public static FindOperation FindAll = (numbers, value) =>
    {
        int count = 0;
        foreach (var n in numbers)
            if (n == value) count++;

        int[] result = new int[count];
        int index = 0;
        foreach (var n in numbers)
            if (n == value)
                result[index++] = n;

        return result;
    };

    // FindIndex
    public static FindIndexOperation FindIndex = (numbers, value) =>
    {
        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] == value) return i;
        return -1;
    };

    // FindLastIndex 
    public static FindIndexOperation FindLastIndex = (numbers, value) =>
    {
        for (int i = numbers.Length - 1; i >= 0; i--)
            if (numbers[i] == value) return i;
        return -1;
    };

    // Sum 
    public static IntOperation Sum = numbers =>
    {
        int total = 0;
        foreach (var n in numbers)
            total += n;
        return total;
    };
}

