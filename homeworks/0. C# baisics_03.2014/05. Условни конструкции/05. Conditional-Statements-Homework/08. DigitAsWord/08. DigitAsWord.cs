// Problem 08.      Digit as Word
//
// Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word
// (in English). Print “not a digit” in case of invalid inut. Use a switch statement. Examples:

//      d	    result
//      2	    two
//      1	    one
//      0	    zero
//      5	    five
//      -0.1	not a digit
//      hi	    not a digit
//      9	    nine
//      10	    not a digit


using System;

    class DigitAsWord
    {
        static void Main()
        {
            Console.Title = "08. Digit as Word";
            string result;
            for (int i = 0; i < 8; i++)         // for 8 examples
            {
                Console.Write("Please enter a digit from 0 to 9: ");
                string input = Console.ReadLine();
                switch (input)
                    {
                        case "0":
                            result = "zero";
                            break;
                        case "1":
                            result = "one";
                            break;
                        case "2":
                            result = "two";
                            break;
                        case "3":
                            result = "three";
                            break;
                        case "4":
                            result = "four";
                            break;
                        case "5":
                            result = "five";
                            break;
                        case "6":
                            result = "six";
                            break;
                        case "7":
                            result = "seven";
                            break;
                        case "8":
                            result = "eight";
                            break;
                        case "9":
                            result = "nine";
                            break;
                        default:
                            result = "not a digit";
                            break;
                    }
                Console.WriteLine("\n{0,5}{1,21}", "d", "result");
                string line = new string ('_', 28);
                Console.WriteLine(" " + line);
                Console.WriteLine("{0,5}{1,18}",input, result);
                Console.WriteLine();
            }    
        }
    }