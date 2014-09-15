// Problem 04.      Multiplication Sign
//
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators. Examples:
//
//  a	    b	    c	    result
//  5	    2	    2	    +
//  -2	    -2	    1	    +
//  -2	    4	    3	    -
//  0	    -2.5	4	    0
//  -1	    -0.5	-5.1	-


using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Title = "04. Multiplication Sign";
            double a, b, c;
            string result = null;
            for (int i = 0; i < 5; i++)         // 5 examples
            {
                while (true)
                {
                    Console.Write("Please enter a, the first real number: ");
                    double? numberA = realNumber(Console.ReadLine());
                    if (numberA != null)
                    {
                        a = numberA.Value;      // we are absolutely sure numberA has a real number for a value
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input for a");
                    }
                }
                while (true)
                {
                    Console.Write("Please enter b, the second real number: ");
                    double? numberB = realNumber(Console.ReadLine());
                    if (numberB != null)
                    {
                        b = numberB.Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input for b");
                    }
                }
                while (true)
                {
                    Console.Write("Please enter c, the third real number: ");
                    double? numberC = realNumber(Console.ReadLine());
                    if (numberC != null)
                    {
                        c = numberC.Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input for c");
                    }
                }
                if ((a > 0) && (b > 0) && (c > 0))
                {
                    result = "+";
                }
                else if ((a < 0) && (b > 0) && (c > 0))
                {
                    result = "-";
                }
                else if ((a > 0) && (b < 0) && (c > 0))
                {
                    result = "-";
                }
                else if ((a > 0) && (b > 0) && (c < 0))
                {
                    result = "-";
                }
                else if ((a < 0) && (b < 0) && (c > 0))
                {
                    result = "+";
                }
                else if ((a > 0) && (b < 0) && (c < 0))
                {
                    result = "+";
                }
                else if ((a < 0) && (b > 0) && (c < 0))
                {
                    result = "+";
                }
                else if ((a < 0) && (b < 0) && (c < 0))
                {
                    result = "-";
                }
                else if (((a == 0) || (b == 0)) || (c == 0))
                {
                    result = "0";
                }
                else  // ей тоя ред би трябвало никога да не се прочете, напълно излишен е, за пример за "добрите практики" е сложен
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine("\n{0,5}{1,5}{2,5}{3,11}", "a", "b", "c", "result");
                string line = new string('_', 25);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,5}{2,5}{3,6}", a, b, c, result);
                Console.WriteLine();
            }
        }
        static double? realNumber(string input) 
        {
            double numParsed = 0d;
            if (double.TryParse(input, out numParsed))
            {
                return numParsed;
            }
            else
            {
                return null;
            }
        }
    }
