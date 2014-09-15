// Problem 9.   Sum of n Numbers
//
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their 
// sum. Note that you may need to use a for-loop. Examples:

//                  numbers	sum		numbers	sum		numbers	sum
//                  3       90      5       6,5     1       1
//                  20              2               1
//                  60              -1
//                  10              -0,5
//                                  4
//                                  2
//

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Title = "09. Sum of n Numbers";        
        int firstN;            // first number, our stopping condition
        double n;            // n - the rest of the input  
        double sum = 0;
        int index = 0;            // the position of the first member of the array //for printing the numbers of the array
        for (int i = 0; i < 3; i++)        // 3 loops for the 3 examples
        {
            while (true)                  // firstN test for correct input
            {
                Console.Write("Please enter the first number: ");
                string inputFirstN = Console.ReadLine();
                if (int.TryParse(inputFirstN, out firstN))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a correct input.");
                }
            }
            double[] numbers = new double[firstN]; // a new array with a size defined by firstN
            // for n, the rest of the input:
            for (int c = 0; c < firstN; c++)// (c < firstN) - the stopping condition 
            {
                while (true)
                {
                    Console.Write("Enter the next number: ");
                    string inputN = Console.ReadLine();
                    if (double.TryParse(inputN, out n))
                    {
                        numbers[c] = n;
                        sum = numbers[c] + sum;
                        break;              // and we'll have the next loop c++ 
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input.");
                    }
                }      
            }
            Console.WriteLine("\n{0, 10}{1, 13}", "numbers", "sum");
            string margin = new string (' ', 3);
            Console.WriteLine("{0}{1}{2, 18}", margin, firstN, sum);
            do                          
            {
                Console.WriteLine("{0}{1}", margin, numbers[index]);
                index++;
            }
            while (index <= (firstN - 1)); // printing numbers[0.. firstN - 1]
            Console.WriteLine();
            sum = 0;                // for the next set of numbers to sum
            index = 0;              // for the next print
        }
    }
}
// oх, колко съм прост- първото числo (n) е стоперът! леле-леле...  
