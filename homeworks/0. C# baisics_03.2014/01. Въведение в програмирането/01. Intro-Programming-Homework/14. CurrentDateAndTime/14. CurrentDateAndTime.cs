// Problem 14.*   Current Date and Time
//
// Create a console application that prints the current date and time. Find in Internet how.

using System;

class CurrentDateAndTime
{
    static void Main()
    {
        Console.Title = "14.* Current Date And Time";
        DateTime timeNow = DateTime.Now;
        Console.WriteLine(timeNow);
    }
}
