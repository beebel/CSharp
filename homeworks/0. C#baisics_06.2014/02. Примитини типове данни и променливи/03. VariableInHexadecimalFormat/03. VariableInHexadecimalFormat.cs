// Problem 3.	Variable in Hexadecimal Format
//
// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).  
// Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure 
// that the result is “254”.

using System;

    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            Console.Title = "03. Variable in Hexadecimal Format";
            int num = 254;
            Console.WriteLine("{0:X}", num); // instead of using windows calculator
            int hex = 0xFE;
            Console.WriteLine(hex);
            Console.WriteLine(hex.ToString("X")); // The hexadecimal ("X") format specifier converts a number to a string of hexadecimal digits.
            string intToString = hex.ToString();
            Console.WriteLine(intToString + 9);
        }
    }

