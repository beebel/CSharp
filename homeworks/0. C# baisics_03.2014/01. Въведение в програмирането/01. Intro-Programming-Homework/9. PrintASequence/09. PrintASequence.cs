// Problem 9.   Print a sequence
//
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintASequence
{
    static void Main()
    {
        Console.Title = "09. Print A Sequence";
        int firstmember = 2;
        int secondmember = -3;
        for (int count = 0; count < 5; count++) // 5 loops, printing 2 members each time per loop 
        {                                       // for the first 10 members of the sequence (5*2 = 10)
            Console.WriteLine(firstmember);
            Console.WriteLine(secondmember);
            firstmember = firstmember + 2;
            secondmember = secondmember - 2;
        }
    }
}
