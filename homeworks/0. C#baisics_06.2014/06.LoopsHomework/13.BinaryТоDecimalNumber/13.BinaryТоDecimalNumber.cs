// Problem 13.	Binary to Decimal Number

// Using loops write a program that converts a binary integer number to its decimal form. The input is entered as
// string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:

//      binary	                        decimal
//      0	                            0
//      11	                            3
//      1010101010101011	            43691
//      1110000110000101100101000000	236476736


using System;
using System.Collections.Generic;
using System.Numerics;

class BinaryТоDecimalNumber
{
static void Main()
{
    Console.Title = "13. Binary to Decimal Number";

    string binText = null;
    BigInteger num;
    double inDecimal = 0;
    int pos = 0;
    List<long> bits = new List<long>();

    for (int t = 1; t <= 4; t++)   // for 4 tests
    {
        Console.WriteLine("test{0}:\n", t);

        while (true)
        {
            Console.Write("Enter a binary integer number:  ");

            binText = Console.ReadLine();
            bool check = BigInteger.TryParse(binText, out num);
            if (check)
            {
                foreach (var item in binText)
                {
                    int bit = Convert.ToInt32(new string(item, 1));

                    if ((bit == 0) || (bit == 1))
                    {
                        bits.Add(bit);
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect input!\n");
                        binText = null;
                        break;
                    }
                }
                if (binText != null)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("\nIncorrect input!\n");
            }
        }

        if (binText != null)
        {
            for (int i = binText.Length - 1; i >= 0; i--)
            {

                inDecimal += bits[pos] * Math.Pow(2, i);
                pos++;
            }
            Console.WriteLine("\n{0}\n", inDecimal);
        }

        pos = 0;
        inDecimal = 0;
        bits.Clear();
        Console.WriteLine("\n\n\n");
    }
}
}
