// Problem 1.	Fibonacci Numbers

// Define a method Fib(n) that calculates the nth Fibonacci number. Examples:

//      n	Fib(n)
//      0	1
//      1	1
//      2	2
//      3	3
//      4	5
//      5	8
//      6	13
//      11	144
//      25	121393

// https://en.wikipedia.org/wiki/Fibonacci_number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "01. Fibonacci Numbers";

        Console.Write("Enter a positive int:  ");
        int n = int.Parse(Console.ReadLine());

        int result = Fib(n);

        Console.WriteLine();
        Console.WriteLine(result);
        Console.WriteLine();
    }

    static int Fib(int n)
    {
        int fib0 = 0;
        int fib1 = 1;
        for (int i = 2; i <= n + 1; i++)
        {
            int tmp = fib0;
            fib0 = fib1;
            fib1 = tmp + fib1;
        }
        return (n > 0 ? fib1 : 0);
    }
}


