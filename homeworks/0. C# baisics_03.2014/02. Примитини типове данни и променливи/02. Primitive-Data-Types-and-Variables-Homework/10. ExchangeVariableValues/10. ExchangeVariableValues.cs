// Problem 10.  Exchange Variable Values
//
// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values.
// Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        Console.Title = "10. Exchange Variable Values";
        int a = 5;
        int b = 10;
        Console.WriteLine("a has the value of {0}", a);
        Console.WriteLine("b has the value of {0}", b);
        int keepsAValue = a;
        a = b;
        b = keepsAValue;
        Console.WriteLine("a has the value of {0}", a);
        Console.WriteLine("b has the value of {0}", b);
    }
}