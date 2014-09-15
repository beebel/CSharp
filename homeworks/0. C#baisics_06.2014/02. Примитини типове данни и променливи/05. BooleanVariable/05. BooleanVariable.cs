// Problem 5.	Boolean Variable
//
// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. 
// Print it on the console.

using System;

    class BooleanVariable
    {
        static void Main()
        {
            Console.Title = "05. Boolean Variable";
            bool isFemale;
            while (true)
            {
                Console.Write("Are you a female? (Yes/ No):     ");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    isFemale = true;
                    break;
                }
                else if (answer == "No")
                {
                    isFemale = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                }
            }
            Console.WriteLine("{0}\n",isFemale);
        }
    }
