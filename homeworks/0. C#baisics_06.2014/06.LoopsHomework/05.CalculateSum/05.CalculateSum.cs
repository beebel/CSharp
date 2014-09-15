// Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

// Write a program that, for a given two integer numbers n and x,
// calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
// Use only one loop. Print the result with 5 digits after the decimal point.

//      n	x	S
//      3	2	2.75000
//      4	3	2.07407
//      5	-4	0.75781


using System;

class CalculateSum
{
    static void Main()
    {

        Console.Title = "05. Calculate Sum";

        double n, x;
        double sum = 1;

        for (int t = 1; t <= 3; t++)             // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number for n:  ");
                string input = Console.ReadLine();
                bool checkInput = double.TryParse(input, out n);

                if (checkInput)
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
                Console.Write("Enter an integer number for x:  ");
                string input = Console.ReadLine();
                bool checkInput = double.TryParse(input, out x);

                if (checkInput)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for x!\n");
                }
            }

            for (int i = 1; i <= n; i++)
            {
                sum += factorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine("\n{0:F5}", sum);
            Console.WriteLine("\n\n\n");

            sum = 1;
        }
    }


    private static double factorial(int n)
    {
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
