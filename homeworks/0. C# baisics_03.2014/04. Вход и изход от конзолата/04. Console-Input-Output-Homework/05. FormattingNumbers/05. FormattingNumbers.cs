// Problem 5.   Formatting Numbers
//
// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c  
// and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
// The number a should be printed in hexadecimal, left aligned; then the number a should be printed 
// in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, 
// right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
//  
//          a	    b	        c	                              result
//   ==================================================================================================
//          254	    11.6	    0.5	                |FE        |0011111110|     11.60|0.500     |
//          499	    -0.5559	    10000	            |1F3       |0111110011|     -0.56|10000     |
//          0	    3	        -0.1234	            |0         |0000000000|         3|-0.123    |

using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Title = "05. Formatting Numbers";
            int a;
            float b, c;
            for (int i = 0; i < 3; i++)                            // for 3 examples
            {
                while (true)  // correct input for a
                {
                    Console.Write("Please enter an integer for number a (0 ≤ a ≤ 500): ");
                    string inputA = Console.ReadLine();
                    if ((int.TryParse(inputA, out a)) && ((a >= 0) && (a <= 500)))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                while (true) // correct input for b
                {
                    Console.Write("Please enter a floating-point for number b: ");
                    string inputB = Console.ReadLine();
                    if (float.TryParse(inputB, out b))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                while (true)    // correct input for c
                {
                    Console.Write("Please enter a floating-point for number c: ");
                    string inputC = Console.ReadLine();
                    if (float.TryParse(inputC, out c))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                Console.WriteLine("\n|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|\n",
                                                            a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c); 
            }
        }
    }
