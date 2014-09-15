using System;

class AgeAfter10Years
{
    static void Main()
    {
        // using DateTime and its methods AddYears() for adding years to the result and Substract() -> for substract birth year and current year  
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long result = DateTime.Today.Subtract(userBirthday).Ticks;  // вадим от днешната дата, рождената дата
        Console.WriteLine("You are {0} years old.", new DateTime(result).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(result).AddYears(10).Year - 1);
    }
}