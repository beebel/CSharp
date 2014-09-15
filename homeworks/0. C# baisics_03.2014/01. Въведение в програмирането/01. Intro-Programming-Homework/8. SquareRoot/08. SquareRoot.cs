// Problem 8    Square Root
//
// Create a console application that calculates and prints the square root of the number 12345. 
// Find in Internet “how to calculate square root in C#”.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Title = "08. Square Root";
        double squareRoot = Math.Sqrt(12345);
        Console.WriteLine(squareRoot);
        Console.WriteLine(Math.Pow(squareRoot, 2));  // checking Math.Sqrt result
    }
}
