// Problem 4.   Variable in Hexadecimal Format
//
// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
// Use Windows Calculator to find its hexadecimal representation. 
// Print the variable and ensure that the result is “254”.


using System;

class HexadecimalFormatVariable
{
    static void Main()
    {
        Console.Title = "04. Variable in Hexadecimal Format";
        int hexa = 0xFE;
        Console.WriteLine(hexa);
        Console.WriteLine(hexa.ToString("X")); // The hexadecimal ("X") format specifier converts a number to a string of hexadecimal digits.
        string intToString = hexa.ToString();
        Console.WriteLine(intToString + 9);
    }
}
