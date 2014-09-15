using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FirstCharToUpper
{
    static void Main()
    {
        Console.Title = "FirstCharToUpper";

        string text = "abcdef";
        string text2 = "nlo";
        Console.WriteLine(text.First().ToString().ToUpper());
        Console.WriteLine(text.First().ToString().ToUpper() + String.Join("", text2.Skip(1)));
    }
}