// Problem 06.       The Biggest of Five Numbers
//
// Write a program that finds the biggest of five numbers by using only five if statements. Examples:

//  a	    b	    c	    d	    e	    biggest
//  5	    2	    2	    4	    1	    5
//  -2	    -22	    1	    0	    0	    1
//  -2	    4	    3	    2	    0	    4
//  0	    -2.5	0	    5	    5	    5
//  -3	    -0.5	-1.1	-2	    -0.1	-0.1


using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Title = "06. The Biggest of Five Numbers";
            double a, b, c, d, e, biggest;
            for (int i = 0; i < 5; i++)         // for 5 examples
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
                while (true)
                {
                    Console.Write("Please enter d, the fourth real number: ");
                    double? numberD = realNumber(Console.ReadLine());
                    if (numberD != null)
                    {
                        d = numberD.Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input for d");
                    }
                }
                while (true)
                {
                    Console.Write("Please enter e, the fifth real number: ");
                    double? numberE = realNumber(Console.ReadLine());
                    if (numberE != null)
                    {
                        e = numberE.Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input for e");
                    }
                }
                biggest = bigger(bigger(bigger(a, b), bigger(c, d)), e);
                Console.WriteLine("\n{0,5}{1,5}{2,5}{3,5}{4,5}{5,11}", "a", "b", "c", "d", "e", "biggest");
                string line = new string('_', 35);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,5}{2,5}{3,5}{4,5}{5,5}", a, b, c, d, e, biggest);
                Console.WriteLine();
            }
        }
        static double? realNumber(string input)     // за коректен вход
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
        static double bigger(double num1, double num2)  // сравняване на две числа
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
