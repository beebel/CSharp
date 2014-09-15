// Problem 1.	Numbers from 1 to N
//
// Write a program that enters from the console a positive integer n and prints all the numbers
// from 1 to n, on a single line, separated by a space. Examples:

//      n	output
//      3	1 2 3
//      5	1 2 3 4 5



using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Title = "01. Numbers from 1 to N";

        int n;

        for (int t = 1; t <= 2; t++)     // for 2 tests
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
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
