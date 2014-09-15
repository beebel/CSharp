// Problem 15.*  Age After 10 Years
//
// Write a program to read your birthday from the console
// and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Title = "15.* Age After 10 Years";
        DateTime correctDate;
        DateTime today = DateTime.Today;
        while (true)       // to gurantee correct data input
        {
            Console.Write("Please, enter your full birth date (dd.mm.yyyy): ");
            string birthDate = Console.ReadLine();
            bool checkDate = DateTime.TryParse(birthDate, out correctDate); // checking the format of the input for correctness
            if ((checkDate) && ((today.CompareTo(correctDate)) >= 0))
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid date!\n");
            }
        }
        long result = today.Subtract(correctDate).Ticks;
        Console.WriteLine("\nRight now you are {0} years old.", new DateTime(result).Year - 1);
        Console.WriteLine("\nAfter 10 years you'll be at {0}.\n", new DateTime(result).AddYears(10).Year - 1);
        if ((today.Day == correctDate.Day) && (today.Month == correctDate.Month))
        {
            Console.WriteLine("Hey, you have a birthday! Wishing you the best! Happy Birthday! :)\n");
        }
    }
}

//using System;

//class AgeAfter10Years
//{
//    static void Main()
//    {
//        Console.Title = "15.* Age After 10 Years";
//        //string birthDate = Console.ReadLine();
//        //string subYear = birthDate.Substring(6); // a new string getting characters from the 6-th (index 6) to the last one of birthDate (yyyy)  
//        //int yearOfBirth = int.Parse(subYear); // converting the year of born into int
//        DateTime inputDate, correctDate;
//        while (true)       // to gurantee correct data input
//        {
//            Console.Write("Please, enter your full birth date dd.mm.yyyy (e.g. 01.07.1992): ");
//            string birthDate = Console.ReadLine();
//            bool checkDate = DateTime.TryParse(birthDate, out correctDate);
//            if (checkDate)
//            {
//                inputDate = correctDate;
//                break;
//            }
//            else
//            {
//                Console.WriteLine("\nInvalid date!\n");
//            }
//        }
//        int yearOfBirth = inputDate.Year;               // getting the year of birth
//        int monthOfBirth = inputDate.Month;
//        int dayOfBirth = inputDate.Day;
//        DateTime timeNow = DateTime.Now;
//        int yearNow = timeNow.Year;               // getting the current year
//        int monthNow = timeNow.Month;
//        int dayNow = timeNow.Day; 
//        if (monthNow <= monthOfBirth)       //covering all cases to gurantee correct output
//        {
//            if (monthNow == monthOfBirth)
//            {
//                if (dayNow <= dayOfBirth)
//                {
//                    if (dayNow == dayOfBirth)
//                    {
//                        int ageNow = yearNow - yearOfBirth;
//                        Console.WriteLine("\nRight now you are {0} years old.", ageNow);
//                        int ageain10years = ageNow + 10;
//                        Console.WriteLine("\nIn 10 years time you'll be at {0} years.\n", ageain10years);
//                        Console.WriteLine("Hey, you have a birthday! Wishing you the best! Happy Birthday! :)\n");      
//                    }
//                    else
//                    {
//                        int ageNow = yearNow - yearOfBirth - 1;
//                        Console.WriteLine("\nRight now you are {0} years old.", ageNow);
//                        int ageain10years = ageNow + 10;
//                        Console.WriteLine("\nIn 10 years time you'll be at {0} years.\n", ageain10years);
//                    }
//                }
//                else 
//                {
//                    int ageNow = yearNow - yearOfBirth;
//                    Console.WriteLine("\nRight now you are {0} years old.", ageNow);
//                    int ageain10years = ageNow + 10;
//                    Console.WriteLine("\nIn 10 years time you'll be at {0} years.\n", ageain10years);
//                }
//            }
//            else
//            {
//                int ageNow = yearNow - yearOfBirth - 1;
//                Console.WriteLine("\nRight now you are {0} years old.", ageNow);
//                int ageain10years = ageNow + 10;
//                Console.WriteLine("\nIn 10 years time you'll be at {0} years.\n", ageain10years);
//            }  
//        }
//        else
//        {
//            int ageNow = yearNow - yearOfBirth;
//            Console.WriteLine("\nRight now you are {0} years old.", ageNow);
//            int ageain10years = ageNow + 10;
//            Console.WriteLine("\nIn 10 years time you'll be at {0} years.\n", ageain10years);
//        }   
//    }
//}

//---------------------------
//и още един, кратък вариант: 

//Тук използвам метода DateTime.Parse() и му подавам входа от потребителя, след което изваждам от днешния ден входа
//(DateTime.Subtract()) и получавам годините. За да получа възрастта след 10 години използвам метода AddYears() na DateTime


//using System;

//class Program
//{
//    static void Main()
//    {
//        // using DateTime and its methods AddYears() for adding years to the result and Substract() -> for substract birth year and current year  
//        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
//        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
//        long result = DateTime.Today.Subtract(userBirthday).Ticks;
//        Console.WriteLine("You are {0} years old.", new DateTime(result).Year - 1);
//        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(result).AddYears(10).Year - 1);
//    }
//}