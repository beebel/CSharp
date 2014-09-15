// Problem 02.      Bonus Score
//
// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//
// •	If the score is between 1 and 3, the program multiplies it by 10.
// •	If the score is between 4 and 6, the program multiplies it by 100.
// •	If the score is between 7 and 9, the program multiplies it by 1000.
// •	If the score is 0 or more than 9, the program prints “invalid score”.

//Examples:

//  score	result
//  2	    20
//  4	    400
//  9	    9000
//  -1	    invalid score
//  10	    invalid score

using System;

class BonusScore
{
    static void Main()
    {
        Console.Title = "02. Bonus Score";
        int score;
        int result = 0;
        for (int i = 0; i < 5; i++)        // 5 examples 
        {
            Console.Write("Please enter the score as an integer number in the range [1..9]: ");
            int? number = parseNullableInt(Console.ReadLine()); // парсване на нулев тип
            score = number.GetValueOrDefault(); // score = number, като score = 0, ako number = null
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    result = score * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    result = score * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    result = score * 1000;
                    break;
                case null:          // ако инпутът не е инт число или дори въобще не е число- "4,33" или "dtedgd" 
                    Console.WriteLine("\nInvalid input, not an integer number.");
                    Console.WriteLine();
                    break;
                default:            // ако парснатия инт е извън [1..9]
                    Console.WriteLine("\nInvalid input, out of the range [1..9].");
                    Console.WriteLine("\n{0,10}{1,15}", "score", "result");
                    string underLine = new string('_', 25);
                    Console.WriteLine("  " + underLine);
                    Console.WriteLine("{0,6}{1,26}", score, "invalid score");
                    Console.WriteLine();
                    break;
            }
            if ((number != null) && (number >= 1) && (number <= 9)) // парснатия инпут е инт, който е в търсения рейндж [1..9]
            {
                Console.WriteLine("\n{0,10}{1,15}", "score", "result");
                string line = new string('_', 25);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,6}{1,15}", score, result);
                Console.WriteLine();
            }      
        }
    }
    static int? parseNullableInt(string input)     //правим си метод който ако успее да парсне връща input-a as scoreParsed , иначе му дава стойност null 
    {
        int scoreParsed = 0;
        if (int.TryParse(input, out scoreParsed))
        {
            return scoreParsed;
        }
        else
        {
            return null;
        }
        // тва с тоя метод адски напомня на процедурите от пайтъна, ама адски много
    }
}
            