// Problem 7.	Calculate N! / (K! * (N-K)!)

// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also
// known as the number of combinations) is calculated by the following formula:

// http://en.wikipedia.org/wiki/Combination

// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
// Try to use only two loops. Examples:

//      n	k	n! / (k! * (n-k)!)
//      3	2	3
//      4	2	6
//      10 	6	210
//      52	5	2598960
 

using System;
using System.Numerics;

class Combinatorics
{
    static void Main()
    {

        Console.Title = "07. Combinatorics";

        int n, k;
        BigInteger result = 0;

        for (int t = 1; t <= 4; t++)         // for 4 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number for n:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out n);

                if ((checkInput) && (n > 1) && (n < 100))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for n!\n");
                }
            }

            while (true)
            {
                Console.Write("Enter an integer number for k:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out k);

                if ((checkInput) && (k < n) && (k > 1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for k!\n");
                }
            }

            result = factorial(n) / (factorial(k) * factorial(n - k));

            Console.WriteLine("\n{0}", result);
            Console.WriteLine("\n\n\n");

            result = 0;
        }     
    }

    private static BigInteger factorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

