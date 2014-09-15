using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ConvertIntegerToHexAndBackAgain
    {
        static void Main()
        {
            Console.Title = "21. convert integer to hex and back again";

            // Store integer 182
            int decValue = 182;
            Console.WriteLine(decValue);

            // Convert integer 182 as a hex in a string variable
            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);

            // Convert the hex string back to the number
            int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decAgain);

            Console.WriteLine();
        }
    }
