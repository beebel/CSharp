// Problem 10.  Fibonacci Numbers 
//
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops. Examples:

//  n	comments
//  1	0
//  3	0 1 1
//  10	0 1 1 2 3 5 8 13 21 34


using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Title = "10. Fibonacci Numbers";
            int n;                  // for the first number
            for (int i = 0; i < 3; i++)     // for the 3 examples
            {
                while (true)                // correct input for n
                {
                    Console.Write("Please enter a positive integer for n: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out n) && (n > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct input.");
                    }
                }
                int[] fibonacci = new int[n];   // n > 0 so the size of fibonacci is at least 1
                if (n == 1)                 // if the size of the array is 1
                {
                    fibonacci[0] = 0;
                }
                if (n == 2)                 // if the size of the array is 2
                {
                    fibonacci[0] = 0;
                    fibonacci[1] = 1;
                }
                for (int c = 2; c < n; c++) // if the size of the array is bigger than 2, the loop counts till c = n-1
                {
                    fibonacci[0] = 0;
                    fibonacci[1] = 1;
                    fibonacci[c] = fibonacci[c - 2] + fibonacci[c - 1];  // the next elements of the array
                }
                Console.WriteLine("\n{0,5}{1,18}", "n", "comments");
                string marginLeft = new string(' ', 4);
                string marginRight = new string(' ', 10);
                Console.Write("{0}{1}{2}", marginLeft, n, marginRight);
                for (int p = 0; p <= (n - 1); p++)  // prints the elements of array from [0] to [n-1](the last one) 
                {
                    Console.Write("{0} ", fibonacci[p]);
                }
                Console.WriteLine("\n");
            }
        }
    }
