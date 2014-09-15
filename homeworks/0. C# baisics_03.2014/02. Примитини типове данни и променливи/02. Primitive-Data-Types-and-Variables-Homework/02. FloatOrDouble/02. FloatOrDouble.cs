// Problem 2.   Float or Double?
//
// Which of the following values can be assigned to a variable of type float
// and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        Console.Title = "02. Float or Double";
        float floatVar = 12.345f;
        float floatVar1 = 3456.091f;
        double doubleVar = 8923.1234857;
        double doubleVar1 = 34.567839023;
        Console.WriteLine("floatVar = {0}\nfloatVar1 = {1}\ndoubleVar = {2}\ndoubleVar1 = {3}", floatVar, floatVar1, doubleVar, doubleVar1);

    }
}
