// Problem 7.   Sum of 5 Numbers
//
// Write a program that enters 5 numbers (given in a single line, separated by a space),  calculates and prints 
// their sum. Examples:

//      numbers	    sum		numbers	        sum		numbers	            sum
//      1 2 3 4 5	15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84


using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Title = "07. Sum of 5 Numbers";
            double real;
            double sum = 0;
            int n = 0;                         // used as a counter for the message line
            bool check = false;
            double[] numbers = new double[5];
            for (int a = 0; a < 3; a++) // to execute the program 3 times (3 times different numbers as an input)
            {
                for (int i = 0; i < 5; i++) // get 3 real numbers and stores them into numbers[]
                {
                    while (true)
                    {
                        if (!check)                     // first check for the message on the console
                        {
                            n = n + 1;
                            Console.Write("Please enter number " + n + ": ");
                            if (n == 5)  // to avoid n getting bigger than 3 in our message line, after successful 
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
                for (int index = 0; index < 5; index++)
                {                                                                             
                    sum = numbers[index] + sum;
                }
                Console.WriteLine("\n{0,17}{1,17}","numbers", "sum");
                string line = new string ('-', 40);
                Console.WriteLine("    " + line);
                Console.WriteLine("{0,10} {1} {2} {3} {4}{5, 12}\n", numbers[0], numbers[1], numbers[2], 
                                                                  numbers[3], numbers[4], sum);
                
                sum = 0;    // for the next set of numbers to sum
            }
        }
    }
