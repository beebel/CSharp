// Problem 11.*     Number as Words

// Write a program that converts a number in the range [0…999] to words, corresponding to the English 
// pronunciation. Examples:

//          numbers	    number as words
//          0	        Zero
//          9	        Nine
//          10	        Ten
//          12	        Twelve
//          19	        Nineteen
//          25	        Twenty five
//          98	        Ninety eight
//          273	        Two hundred and seventy three
//          400	        Four hundred
//          501	        Five hundred and one
//          617	        Six hundred and seventeen
//          711	        Seven hundred and eleven
//          999	        Nine hundred and ninety nine
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumberAsWords
{
    static void Main()
    {
        Console.Title = "11.* Number as Words";
        int num;
        string result = null;
        for (int i = 0; i < 13; i++)            // for 13 examples
        {
            while (true)        // гарантираме си, че num ще е в [0..999]
            {
                Console.Write("Please enter an integer number in the range [0..999]: ");
                string input = Console.ReadLine();
                if (((int.TryParse(input, out num)) && (num >= 0)) && (num <= 999))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, not in the range [0..999]");
                }
            }
            switch (num / 100)
            {
                case 0: break;
                case 1: result = "one hundred "; break;
                case 2: result = "two hundred "; break;
                case 3: result = "tree hundred "; break;
                case 4: result = "four hundred "; break;
                case 5: result = "five hundred "; break;
                case 6: result = "six hundred "; break;
                case 7: result = "seven hundred "; break;
                case 8: result = "eight hundred "; break;
                case 9: result = "nine hundred "; break;
                default: break;
            }
            if ((num % 100 != 0) && (num / 100 != 0))  // без тия от 0 до 99 и кръглите стотици 100, 200, 300 и т.н.
            {
                result = result + "and ";
            }
            switch ((num / 10) % 10) // дава ни десетиците в числото (123 / 10) % 10 = 12 % 10 = 2 
            {
                case 0: break;  // десетицата е нула
                case 1:         // за числата от 10 до 19
                    switch (num % 10) // дава ни единиците (123 % 10 = 3)
                    {
                        case 0: result = result + "ten "; break;
                        case 1: result = result + "eleven "; break;
                        case 2: result = result + "twelve "; break;
                        case 3: result = result + "thirteen "; break;
                        case 4: result = result + "fourteen "; break;
                        case 5: result = result + "fiveteen "; break;
                        case 6: result = result + "sixteen "; break;
                        case 7: result = result + "seventeen "; break;
                        case 8: result = result + "eighteen "; break;
                        case 9: result = result + "nineteen "; break;
                        default:  break;
                    } break;
                case 2: result = result + "twenty "; break;
                case 3: result = result + "thirty "; break;
                case 4: result = result + "forty "; break;
                case 5: result = result + "fifty "; break;
                case 6: result = result + "sixty "; break;
                case 7: result = result + "seventy "; break;
                case 8: result = result + "eighty "; break;
                case 9: result = result + "ninety "; break;
                default: break;
            }
            switch (num % 10)  // за единиците
            {
                case 0: if (num == 0)
                         {
                             result = "zero";
                         }
                    break;
                case 1: if (((num / 10) % 10) == 1) break;  // т.е. ако е 11- разгледан случай
                    result = result + "one";   break;
                case 2: if (((num / 10) % 10) == 1) break;      // за 12
                    result = result + "two";   break;
                case 3: if (((num / 10) % 10) == 1) break;      // за 13
                    result = result + "three";   break;
                case 4: if (((num / 10) % 10) == 1) break;      // за 14
                    result = result + "four";   break;
                case 5: if (((num / 10) % 10) == 1) break;      // за 15
                    result = result + "five";   break;
                case 6: if (((num / 10) % 10) == 1) break;      // за 16
                    result = result + "six";   break;
                case 7: if (((num / 10) % 10) == 1) break;      // за 17
                    result = result + "seven";   break;
                case 8: if (((num / 10) % 10) == 1) break;      // за 18
                    result = result + "eight";   break;
                case 9: if (((num / 10) % 10) == 1) break;      // за 19
                    result = result + "nine";   break;
                default: break;
            }
            result = FirstCharToUpper(result);  // да си направим първата буква главна
            Console.WriteLine(result);
            result = null;
        }   
    }
    static string FirstCharToUpper(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException("Error!");
        return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
    }
}