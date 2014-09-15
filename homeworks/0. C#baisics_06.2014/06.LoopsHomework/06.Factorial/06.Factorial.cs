// Problem 6.	Calculate N! / K!

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:

//      n	k	n! / k!
//      5	2	60
//      6	5	6
//      8	3	6720


using System;

class Factorial
{
    static void Main()
    {

        Console.Title = "06. Factorial";

        int n, k;
        int result = 0;

        for (int t = 1; t <= 3; t++)         // for 3 tests
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

            result = factorial(n) / factorial(k);

            Console.WriteLine("\n{0}",result);
            Console.WriteLine("\n\n\n");

            result = 0;
        }    
    }

    private static int factorial(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
