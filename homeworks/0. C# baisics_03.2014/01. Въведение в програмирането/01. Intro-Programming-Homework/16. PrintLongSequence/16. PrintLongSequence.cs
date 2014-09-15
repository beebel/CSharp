// Problem 16.*  Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
// You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintALongSequence
{
    static void Main()
    {
        Console.Title = "16.* Print A Long Sequence";
        for (int i = 2; i < 1002; i++)
        {
            Console.Write("{0} ", i % 2 == 0? i: -i);    // ternary operator
        }
        Console.WriteLine("\n");
    }
}
