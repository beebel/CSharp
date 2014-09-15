// Problem 15.	Hexadecimal to Decimal Number

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality. Examples: 

//          hexadecimal	    decimal
//          FE	            254
//          1AE3	        6883
//          4ED528CBB4	    338583669684


using System;
using System.Collections.Generic;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Title = "15. Hexadecimal to Decimal Number";

        string hexValue = null;
        double num;
        double decNum = 0;
        int pow;
        List<double> hex = new List<double>();

        for (int t = 1; t <= 3; t++)    // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter a a hexadecimal integer number:  ");
                hexValue = Console.ReadLine();
                pow = hexValue.Length - 1;

                foreach (var item in hexValue)
                {

                    switch (item)
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            num = char.GetNumericValue(item);
                            hex.Add(num);
                            break;

                        case 'A':
                            hex.Add(10);
                            break;
                        case 'B':
                            hex.Add(11);
                            break;
                        case 'C':
                            hex.Add(12);
                            break;
                        case 'D':
                            hex.Add(13);
                            break;
                        case 'E':
                            hex.Add(14);
                            break;
                        case 'F':
                            hex.Add(15);
                            break;
                        default:
                            hexValue = null;
                            break;
                    }
                }
                if (hexValue != null)
                {
                    Console.WriteLine("\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input- not a hex!\n");
                }
            }

            if (hexValue != null)
            {
                for (int i = 0; i < hex.Count; i++)
                {
                    decNum += hex[i] * Math.Pow(16, pow);
                    pow--;
                }

                Console.WriteLine("\n{0}", decNum);
            }

            hex.Clear();
            decNum = 0;
            Console.WriteLine("\n\n\n");
        }
    }
}
