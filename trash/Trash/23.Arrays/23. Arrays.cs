using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Arrays
{
    static void Main()
    {
        Console.Title = "23. Arrays";

        int[] numbers = new int[4];

        numbers[0] = 5;
        numbers[1] = 3;
        numbers[2] = 19;
        numbers[3] = 1;

        Array.Reverse(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Array.Sort(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.ToString());
        Console.WriteLine(numbers.First());
        Console.WriteLine(numbers.Last());
        Console.WriteLine(numbers.First() + numbers.Last());
    }
}
