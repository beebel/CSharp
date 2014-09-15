// Problem 05.       The Biggest of 3 Numbers
//
// Write a program that finds the biggest of three numbers. Examples:

//  a	    b	    c	    biggest
//  5	    2	    2	    5
//  -2	    -2	    1	    1
//  -2	    4	    3	    4
//  0	    -2.5	5	    5
//  -0.1	-0.5	-1.1	-0.1


using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.Title = "05. The Biggest of 3 Numbers";
            double a, b, c, biggest;
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
                biggest = bigger(bigger(a, b), c);
                Console.WriteLine("\n{0,5}{1,5}{2,5}{3,11}", "a", "b", "c", "biggest");
                string line = new string('_', 25);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,5}{2,5}{3,5}", a, b, c, biggest);
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
