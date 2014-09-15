// Problem 07.       Sort 3 Numbers with Nested Ifs

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements. Don’t use arrays and the built-in sorting functionality. Examples:

//      a	    b	    c	    result
//      5	    1	    2	    5 2 1
//      -2	    -2	    1	    1 -2 -2
//      -2	    4	    3	    4 3 -2
//      0	    -2.5	5	    5 0 -2.5
//      -1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//      10	    20	    30	    30 20 10
//      1	    1	    1	    1 1 1

using System;

class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.Title = "07. Sort 3 Numbers with Nested Ifs";
            double a, b, c, biggest, middle, smallest;
            for (int i = 0; i < 7; i++)         // 7 examples
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
                if (bigger(a, b) > c)
                {
                    biggest = bigger(a, b);
                    if (biggest == a)
                    {
                        middle = bigger(b, c);
                        smallest = smaller(b, c);
                    }
                    else    // biggest == b
                    {
                        middle = bigger(a, c);
                        smallest = smaller(a, c);
                    }
                }
                else    // bigger(a, b) < c
                {
                    biggest = c;
                    middle = bigger(a, b);
                    smallest = smaller(a, b);
                }
                Console.WriteLine("\n{0,5}{1,5}{2,5}{3,11}", "a", "b", "c", "result");
                string line = new string('_', 25);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,5}{2,5}{3,6} {4} {5}", a, b, c, biggest, middle, smallest);
                Console.WriteLine();
            }
        }
            static double? realNumber(string input)  // коректен вход
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
            static double bigger(double num1, double num2)  // сравняване на две числа- bigger
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
            static double smaller (double num1, double num2)    // сравняване на две числа - smaller
            {
                if (num1 < num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
    }
