// Problem 11.  Employee Data
// A marketing company wants to keep record of its employees.
// Each record would have the following characteristics:
//
// •	First name
// •	Last name
// •	Age (0...100)
// •	Gender (m or f)
// •	Personal ID number (e.g. 8306112507)
// •	Unique employee number (27560000…27569999)
//
// Declare the variables needed to keep the information for a single employee 
// using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Title = "11. Employee Data";
        string firstName = "Pesho";
        string lastName = "Peshev";
        byte age = 36;
        char gender = 'm';
        long personalID = 8306112507;
        string uniqueNumber = "9999";
        string employeeNumber = "2576" + uniqueNumber; 
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(personalID);
        Console.WriteLine(employeeNumber);
    }
}