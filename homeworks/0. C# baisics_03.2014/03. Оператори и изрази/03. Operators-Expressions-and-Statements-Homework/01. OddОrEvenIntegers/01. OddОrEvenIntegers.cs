

// Problem 1.   Odd or Even Integers
//
// Write an expression that checks if given integer is odd or even. Examples:
//
//      n       Odd?
// ------------------------
//      3	    true
//      2	    false
//      -2	    false
//      -1	    true
//      0	    false


using System;

class OddОrEvenIntegers
{
    static void Main()
    {
        Console.Title = "01. Odd or Even Integers";
        int num;
        for (int i = 0; i < 5; i++) // for five loops i.e. five numbers to check
        {
            while (true)    // to gurantee a corect integer input
            {
                Console.Write("Please enter the integer number you want to check:   ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out num);
                if (check == true)
                {
                    if ((num >= int.MinValue) && (num <= int.MaxValue)) // a true integer
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
            bool result = (num % 2 != 0);  // result is true if num is odd
            Console.WriteLine("\n{0,6}{1,14}", "n", "Odd?");
            string line = new String('-', 24);
            Console.WriteLine(line);
            Console.WriteLine("{0,6}{1,14}\n", num, result);
        }
    }
}