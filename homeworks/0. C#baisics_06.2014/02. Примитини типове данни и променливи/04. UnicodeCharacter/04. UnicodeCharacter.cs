// Problem 4.	Unicode Character
//
// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' 
// syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42.
// The output should be “*”.

using System;

    class UnicodeCharacter
    {
        static void Main()
        {
            Console.Title = "04. Unicode Character";
            int hexFormat = 42;
            Console.WriteLine("the hexadecimal representation of 42 is --> {0}\n", hexFormat.ToString("X"));
            char symbol = '\u002A';
            Console.WriteLine(symbol);
            Console.WriteLine((int)'*');
            Console.WriteLine((int) symbol);
            Console.WriteLine((char) 42);
            Console.WriteLine();
        }
    }
