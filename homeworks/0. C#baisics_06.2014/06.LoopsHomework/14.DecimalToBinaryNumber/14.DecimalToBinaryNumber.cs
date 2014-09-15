// Problem 14.	Decimal to Binary Number

// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality. Examples:

//      decimal	        binary
//      0	            0
//      3	            11
//      43691	        1010101010101011
//      236476736	    1110000110000101100101000000



using System;
using System.Collections.Generic;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Title = "14. Decimal to Binary Number";

        string decimalText = null;
        int num;
        int? rem = null;

        List<string> bits = new List<string>();

        for (int t = 1; t <= 4; t++)   // for 4 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number:  ");

                decimalText = Console.ReadLine();
                bool check = int.TryParse(decimalText, out num);
                if (check)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect input!\n");
                }
            }

            Console.WriteLine();

            if (num == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                while (num >= 1)
                {
                    rem = num % 2;
                    num = num / 2;

                    bits.Add(rem.ToString());
                }

                for (int i = bits.Count - 1; i >= 0; i--)
                {
                    Console.Write(bits[i]);
                }
            }

            Console.WriteLine("\n\n\n");

            rem = null;
            bits.Clear();
        }
    }
}