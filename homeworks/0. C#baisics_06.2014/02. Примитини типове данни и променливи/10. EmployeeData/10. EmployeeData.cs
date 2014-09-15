// Problem 10.	 Employee Data
// 
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//
//      •	First name
//      •	Last name
//      •	Age (0...100)
//      •	Gender (m or f)
//      •	Personal ID number (e.g. 8306112507)
//      •	Unique employee number (27560000…27569999)
//
// Declare the variables needed to keep the information for a single employee using appropriate
// primitive data types. Use descriptive names. Print the data at the console. 

using System;

    class EmployeeData
    {
        static void Main()
        {
            Console.Title = "10. Employee Data";
            string firstName = "Pesho";
            string lastName = "Peshev";
            byte age = 30;
            char gender = 'm';
            string personalID = "8306112507";
            string employeeNumber = "9999";
            string uniqueNumber = "2756" + employeeNumber;
            Console.WriteLine("First Name:               " + firstName);
            Console.WriteLine("Last Name:                " + lastName);
            Console.WriteLine("Age:                      " + age);
            Console.WriteLine("Gender:                   " + gender);
            Console.WriteLine("Personal ID number:       " + personalID);
            Console.WriteLine("Unique employee number:   " + uniqueNumber);
            Console.WriteLine();
        }
    }