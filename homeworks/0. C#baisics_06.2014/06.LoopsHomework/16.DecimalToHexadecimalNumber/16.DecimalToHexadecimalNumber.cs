// Problem 16.	Decimal to Hexadecimal Number

// Using loops write a program that converts an integer number to its hexadecimal representation. The input is
// entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.
// Examples:

//          decimal	        hexadecimal
//          254	            FE
//          6883	        1AE3
//          338583669684	4ED528CBB4


using System;
using System.Collections.Generic;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Title = "16. Decimal to Hexadecimal Number";

        string decimalValue = null;
        long num;
        long rem = 0;

        List<string> hex = new List<string>();

        for (int t = 1; t <= 3; t++)        // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number:  ");

                decimalValue = Console.ReadLine();
                bool check = long.TryParse(decimalValue, out num);
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

            while (num >= 16)
            {
                rem = num % 16;
                num = num / 16;

                hex.Add(rem.ToString());
            }

            hex.Add(num.ToString());

            for (int i = hex.Count - 1; i >= 0; i--)
            {
                switch (hex[i])
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        Console.Write(hex[i]);
                        break;

                    case "10":
                        Console.Write("A");
                        break;
                    case "11":
                        Console.Write("B");
                        break;
                    case "12":
                        Console.Write("C");
                        break;
                    case "13":
                        Console.Write("D");
                        break;
                    case "14":
                        Console.Write("E");
                        break;
                    case "15":
                        Console.Write("F");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

            Console.WriteLine("\n\n\n");
            hex.Clear();
        }
    }
}
