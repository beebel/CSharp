// Problem 9.	Matrix of Numbers

// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
// and prints a matrix like in the examples below. Use two nested loops. Examples:

//      n	matrix
//      2	1 2
//          2 3

//      n	matrix
//      3	1 2 3
//          2 3 4
//          3 4 5

//      n	matrix
//      4	1 2 3 4
//          2 3 4 5
//          3 4 5 6
//          4 5 6 7


using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Title = "09. Matrix of Numbers";

        int n;

        for (int t = 1; t <= 3; t++)         // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number for n:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out n);

                if ((checkInput) && (n >= 1) && (n <= 20))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for n!\n");
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int c = i; c <= i + (n - 1); c++)
                {
                    Console.Write("{0} ", c);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");
        }
    }
}