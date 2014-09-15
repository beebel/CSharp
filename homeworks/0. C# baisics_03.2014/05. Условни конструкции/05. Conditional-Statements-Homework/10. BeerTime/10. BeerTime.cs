// Problem 10.*     Beer Time

// A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
// (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)and prints “beer time” or
// “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
// Note that you may need to learn how to parse dates and times. Examples:

//          time	    result
//          1:00 PM	    beer time
//          4:30 PM	    beer time
//          10:57 PM	beer time
//          8:30 AM	    non-beer time
//          02:59 AM	beer time
//          03:00 AM	non-beer time
//          03:26 AM	non-beer time


using System;

    class BeerTime
    {
        static void Main()
        {
            Console.Title = "10.* Beer Time";
            DateTime time;
            DateTime startBeerTime = DateTime.Parse("1:00 PM");
            DateTime endBeerTime = DateTime.Parse("3:00 AM");
            string result = null;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Please enter the time in format “HH:mm tt”: ");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out time))
                {
                    if ((time >= startBeerTime) || (time < endBeerTime))
                    {
                        result = "beer time";
                    }
                    else
                    {
                        result = "non-beer time";
                    }      
                }
                else
                {
                    Console.WriteLine("invalid time!");
                }
                Console.WriteLine("\n{0,10}{1,24}", "time", "result");
                string line = new string('_', 40);
                Console.WriteLine(" " + line);
                Console.WriteLine("{0,13}{1,16}", time, result);
                Console.WriteLine();
            }    
        }
    }
