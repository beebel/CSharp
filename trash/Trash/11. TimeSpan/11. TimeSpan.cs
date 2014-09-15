using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UseOfTimeSpan
{
    static void Main()
    {
        Console.Title = "TimeSpan";   // TimeSpan value e някакъв период от време. 

        Console.Write("Which Date you have been born(dd.mm.yyyy): ");
        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Now;
        TimeSpan ts = today - dateOfBirth;

        //към минималната дата 01.01.0001 добавяме дните от ts.Days
        DateTime Age = DateTime.MinValue.AddDays(ts.Days);
        //Получава се нещо от сорта 11.12.0025 като се извади 1 от годината месеца и деня се получава възрастта на която съм. (защото мин дата започва от 1, а не от 0 за ден месец и година)
        Console.WriteLine("Now i'm at:  {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1);
        //Тук добавям само 9 защото MinValue = 0001г.
        int ageAFterTen = Age.Year + 9;
        Console.WriteLine("After 10 Years I'll be at: {0} Years {1} Month {2} Days", ageAFterTen, Age.Month - 1, Age.Day - 1);
    }
}  
