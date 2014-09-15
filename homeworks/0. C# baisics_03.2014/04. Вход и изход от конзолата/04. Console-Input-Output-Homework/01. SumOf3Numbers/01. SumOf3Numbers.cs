// Problem 01.  Sum of 3 Numbers
//
// Write a program that reads 3 real numbers from the console and prints their sum. Examples:
//
//      a	    b	    c	    sum
//  ===================================
//      3	    4	    11	    18
//      -2	    0	    3	    1
//      5.5	    4.5	    20.1	30.1

using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Title = "01. Sum of 3 Numbers";
            double real;
            double sum = 0;
            int n = 0;                         // used as a counter for the message line
            bool check = false;
            double[] numbers = new double [3];
            for (int a = 0; a < 3; a++) // to execute the program 3 times (3 times different numbers as an input)
            {
                for (int i = 0; i < 3; i++) // get 3 real numbers and stores them into numbers[]
                {
                    while (true)
                    {
                        if (!check)                     // first check for the message on the console
                        {
                            n = n + 1;
                            Console.WriteLine("Please enter a real number for number " + n + ".");
                            if (n == 3)  // to avoid n getting bigger than 3 in our message line, after successful 
                            {            // completion of the first set of correct input numbers
                                n = 0;
                            }
                        }
                        string input = Console.ReadLine();
                        check = double.TryParse(input, out real);
                        if (check)                    // second check for the input- to check if it is correct
                        {
                            numbers[i] = real;
                            check = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a real number.");
                            check = true;
                        }
                    }
                }
                for (int index = (numbers.Length - 1); index >= (numbers.Length - 3); index--)// always getting the last 
                {                                                                             // 3 numbers of the list
                    sum = numbers[index] + sum;
                }
                Console.Write("\nThe sum is: {0}\n\n", sum);
                sum = 0;                                              // for the next set of numbers to sum
            }     
        }
    }
                                     