// Problem 2.	Numbers Not Divisible by 3 and 7
//
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not
// divisible by 3 and 7, on a single line, separated by a space. Examples:

//      n	output
//      3	1 2
//      10	1 2 4 5 8 10


using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Title = "02. Numbers Not Divisible by 3 and 7";

        int n;

        for (int t = 1; t <= 2; t++)    // for 2 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter a positive integer:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out n);

                if (checkInput && n >= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input!\n");
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
