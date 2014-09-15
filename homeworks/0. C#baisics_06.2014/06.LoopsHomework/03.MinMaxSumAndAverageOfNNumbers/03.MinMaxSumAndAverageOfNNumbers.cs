// Problem 3.	Min, Max, Sum and Average of N Numbers
//
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the
// maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The 
// input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below. Examples:

//      input	output                  input	output 
//      3       min = 1                 2       min = -1     
//      2       max = 5                 -1      max = 4
//      5       sum = 8                 4       sum = 3
//      1	    avg = 2.67                      avg = 1.50





using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Title = "03. Min, Max, Sum and Average of N Numbers";

        int n, num;
        int min = int.MinValue;
        int max = int.MaxValue;
        int sum = 0;
        double avg = 0d;

        for (int t = 1; t <= 2; t++)           // for 2 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter a positive number for the elements in the sequence:  ");
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
                while (true)
                {
                    Console.Write("Enter number {0}:  ", i);
                    string input = Console.ReadLine();
                    bool checkInput = int.TryParse(input, out num);

                    if (checkInput)
                    {
                        if (i == 1)
                        {
                            min = num;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input!\n");
                    }
                }

                if (num <= min)
                {
                    min = num;
                }
                else
                {
                    max = num;
                }
                sum += num;
                avg = sum / Convert.ToDouble(n);
            }
            Console.WriteLine();
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
            Console.WriteLine("\n\n\n");

            min = int.MinValue;
            max = int.MaxValue;
            sum = 0;
            avg = 0d;
        }
    }
}
