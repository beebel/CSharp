// Problem 7.    Strings and Objects
//
// Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it
// with the concatenation of the first two variables (mind adding an interval between).  
// Declare a third string variable and initialize it with the value of the object variable 
// (you should perform type casting).

using System;

class StringsAndObjects
{
    static void Main()
    {
        Console.Title = "07. Strings and Objects";
        string var1 = "Hello";
        string var2 = "World";
        object concat = var1 + " " + var2;
        Console.WriteLine(concat);
    }
}
