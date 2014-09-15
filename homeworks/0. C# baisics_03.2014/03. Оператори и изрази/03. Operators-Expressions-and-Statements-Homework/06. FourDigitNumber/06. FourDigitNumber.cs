// Problem 6.   Four-Digit Number
//
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// •	Prints on the console the number in reversed order: dcba (in our example 1102).
// •	Puts the last digit in the first position: dabc (in our example 1201).
// •	Exchanges the second and the third digits: acbd (in our example 2101).
//
// The number has always exactly 4 digits and cannot start with 0. Examples:
//
//  n	sum of digits	reversed	last digit in front	    second and third digits exchanged
// 2011	     4	           1102	           1201	                    2101
// 3333	     12	           3333	           3333	                    3333
// 9876	     30	           6789	           6987	                    9786


using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Title = "06. Four-Digit Number";
            int num;
            for (int i = 0; i < 3; i++) // for three loops i.e. three integer numbers to input 
            {
                while (true)    // to gurantee the corect input of int
                {
                    Console.Write("Please enter a positive, four-digited integer number:    ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out num))    // if (true)
                    {
                        if ((num > 0) && (num <= 9999)) // four-digited int 
                        {
                            break;
                        }
                        Console.WriteLine("The input is not a four-digitet number!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                int pos0 = num % 10; // the digit at a position 0 (from left to the right)
                int pos1 = (num / 10) % 10; // the digit at a position 1
                int pos2 = (num / 100) % 10; // the digit at a position 2
                int pos3 = (num / 1000); // the digit at a position 3
                int sumOfDigits = pos0 + pos1 + pos2 + pos3;
                string stringPos0 = pos0.ToString();
                string stringPos1 = pos1.ToString();
                string stringPos2 = pos2.ToString();
                string stringPos3 = pos3.ToString();
                string reversed = stringPos0 + stringPos1 + stringPos2 + stringPos3;
                string lastDigitInFront = stringPos0 + stringPos3 + stringPos2 + stringPos1;
                string secondAndThirdDigitExchanged = stringPos3 + stringPos1 + stringPos2 + stringPos0;
                Console.WriteLine("\n{0}{1}{2}{3}{4}", "n|", "|sum of digits|", "|reversed|", "|last digit in front|", "|second and third digit exchange");
                string line = new String ('-', 80);
                Console.WriteLine(line);
                Console.WriteLine("{0}{1,5}{2,15}{3,15}{4,30}\n", num, sumOfDigits, reversed, lastDigitInFront, secondAndThirdDigitExchanged);
            }
        }
    }

