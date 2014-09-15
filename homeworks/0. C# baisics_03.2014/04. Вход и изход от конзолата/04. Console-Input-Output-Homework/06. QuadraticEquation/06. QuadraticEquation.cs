// Problem 6.   Quadratic Equation
//
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it
// (prints its real roots). Examples:
//
//  a	    b	    c	    roots
// ----------------------------------
//  2	    5	    -3	    x1=-3; x2=0.5
//  -1	    3	    0	    x1=3; x2=0
//  -0.5	4	    -8	    x1=x2=4
//  5	    2	    8	    no real roots



using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Title = "06. Quadratic Equation";
            double a, b, c;
            double checkD; //  за дискриминтата 
            string roots = "empty";
            for (int i = 0; i < 4; i++) // 4 examples
            {
                while (true)  // correct input for a
                {
                    Console.Write("Please enter a: ");
                    string inputA = Console.ReadLine();
                    if ((double.TryParse(inputA, out a)) && a != 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                while (true) // correct input for b
                {
                    Console.Write("Please enter b: ");
                    string inputB = Console.ReadLine();
                    if (double.TryParse(inputB, out b))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                while (true)    // correct input for c
                {
                    Console.Write("Please enter c: ");
                    string inputC = Console.ReadLine();
                    if (double.TryParse(inputC, out c))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not correct");
                    }
                }
                checkD = ((b * b) - (4 * a * c));
                if (checkD < 0)
                {
                    roots = "no real roots";
                }
                if (checkD == 0)
                {
                    double oneX = -(b / (2 * a));
                    roots = oneX.ToString();
                    roots = "x1=x2=" + roots;
                }
                if (checkD > 0)
                {
                    double x1 = (-b - (Math.Sqrt(b * b - 4 *a * c))) / (2 * a);
                    string x1String = x1.ToString();
                    x1String = "x1=" + x1String + "; ";
                    double x2 = (-b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
                    string x2String = x2.ToString();
                    x2String = "x2=" + x2String;
                    roots = x1String + x2String;
                }
                Console.WriteLine("\n{0, 10}{1, 10}{2, 10}{3, 20}", "a", "b", "c", "roots");
                string line = new string('-', 53);
                Console.WriteLine("     " + line);
                Console.WriteLine("{0, 10}{1, 10}{2, 10}{3, 25}\n", a, b, c, roots);
            }
        }
    }
