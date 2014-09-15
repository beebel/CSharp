// Problem 11.	Random Numbers in Given Range

// Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range 
// [min...max]. Examples:

//      n	    min	    max	    random numbers
//      5	    0	    1	    1 0 0 1 1
//      10	    10	    15	    12 14 12 15 10 12 14 13 13 11

// Note that the above output is just an example. Due to randomness, your program most probably will produce 
// different results.


using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Title = "11. Random Numbers in Given Range";

        int n, min, max;
        Random rnd = new Random();
        int dice = 0;


        for (int t = 1; t <= 2; t++)         // for 2 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter a positive integer number for n:  ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out n);

                if (check)
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
                Console.Write("Enter integer number for min:  ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out min);

                if (check)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for min!\n");
                }
            }

            while (true)
            {
                Console.Write("Enter integer number for max, bigger than min:  ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out max);

                if ((check) && (max >= min))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for max!\n");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                dice = rnd.Next(min, max + 1);
                Console.Write("{0} ", dice);
            }
            Console.WriteLine("\n\n\n");
        }      
    }
}

//Random rnd = new Random();

// examples:

//int month = rnd.Next(1, 13); // creates a number between 1 and 12
//int dice = rnd.Next(1, 7); // creates a number between 1 and 6
//int card = rnd.Next(52); // creates a number between 0 and 51