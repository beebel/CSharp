// Problem 5.   Unicode Value
//
// Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it.
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.

using System;

class UnicodeValue
{
    static void Main()
    {
        Console.Title = "05. Unicode Value";

        char symbol = '\u0048'; //  \uXXXX Unicode code for the symbol with number 72 (72 = 0x48 hexadecimal) 
        Console.WriteLine(symbol);
        symbol = (char)72;      //  72 = 0x48 
        Console.WriteLine(symbol);
        symbol = Convert.ToChar(0x48);  // or Convert.ToChar(72)- same thing. another way to convert int to char.   
        Console.WriteLine(symbol);
        int intH = (int)symbol;     // and the reverse process  
        Console.WriteLine(intH);
        Console.WriteLine(Convert.ToInt32('H'));
    }
}
