// Problem 9.	Exchange Variable Values
//
// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using 
// some programming logic. Print the variable values before and after the exchange.

using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            Console.Title = "09. Exchange Variable Values";
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
            int exch = a;
            a = b;
            b = exch;
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
        }
    }
