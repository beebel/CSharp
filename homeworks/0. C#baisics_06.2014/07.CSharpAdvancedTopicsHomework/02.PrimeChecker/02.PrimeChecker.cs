// Problem 2.	Prime Checker

// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:

//      n	            IsPrime(n)
//      0	            false
//      1	            false
//      2	            true
//      3	            true
//      4	            false
//      5	            true
//      323	            false
//      337	            true
//      6737626471	    true
//      117342557809	false

// https://en.wikipedia.org/wiki/Prime_number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrimeChecker
{
    static void Main()
    {
        Console.Title = "02. Prime Checker";

        Console.Write("Enter a positive num:  ");

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(IsPrime(n) == true ? "true" : "false");
        Console.WriteLine();

    }

    static bool IsPrime(int n)
    {
        bool result = true;

        if (n == 0 || n == 1)
        {
            result = false;
        }

        else
        {
            for (int i = 2; i < n; i++)
            {
                for (int del = 2; del < n; del++)
                {
                    if (n % del == 0)
                    {
                        result = false;
                        break;
                    }
                }
                if (result == false)
                {
                    break;
                }
            }
        }

        return result;
    }
}
