// Problem 8.   Numbers from 1 to n
//
// Write a program that reads an integer number n from the console and prints all the numbers in the interval 
// [1..n], each on a single line. Note that you may need to use a for-loop. Examples:

//          numbers	sum		numbers	sum		numbers	sum
//          3	    1       5       1       1       1
//                  2               2
//                  3	            3
//                                  4
//                                  5
//
//
 
using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Title = "08. Numbers from 1 to n";
            int n;
            for (int i = 0; i < 3; i++) // for 3 examples
            {
                while (true)
                {
                    Console.Write("Please enter a possitive integer number for n: ");
                    string input = Console.ReadLine();
                    if ((int.TryParse(input, out n)) && n >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct input.");
                    }
                }
                Console.WriteLine("\n{0,14}{1,10}", "numbers", "sum");
                Console.WriteLine("{0,8}{1,14}", n, 1);
                if (n == 1)
                {
                    break;
                }
                else
                {
                    for (int p = 2; p <= n; p++)    // for the print under sum
                    {
                        Console.WriteLine("{0,22}", p);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

