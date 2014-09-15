using System;
using System.Collections.Generic;

class CharNumericValueToInt
{
    static void Main()
    {
        Console.Title = "20. CharNumericValueToInt";

        // method 1:

        Console.WriteLine(char.GetNumericValue('¼'));

        // method 2:

        char foo = '2';
        int bar = Convert.ToInt32(new string(foo, 1));

        Console.WriteLine(bar);

    }
}
