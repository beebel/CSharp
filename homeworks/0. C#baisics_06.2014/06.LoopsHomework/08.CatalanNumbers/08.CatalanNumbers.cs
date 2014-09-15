// Problem 8.	Catalan Numbers

// In combinatorics, the Catalan numbers are calculated by the following formula:
// http://en.wikipedia.org/wiki/Catalan_number

// Write a program to calculate the n-th Catalan number by given n (1 < n < 100). Examples:

//      n	Catalan(n)
//      0	1
//      5	42
//      10	16796
//      15	9694845


using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "08. Catalan Numbers";

        int n;
        BigInteger result = 0;

        for (int t = 1; t <= 4; t++)         // for 4 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number for n:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out n);

                if ((checkInput) && (n >= 0) && (n < 100))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for n!\n");
                }
            }

            result = factorial(2 * n) / (factorial(n + 1) * factorial(n));

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
