// Problem 9.   Trapezoids
//
// Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:
//
// a	   b	    h	    area
//----------------------------------
// 5	   7	    12	    72
// 2	   1	    33	    49.5
// 8.5	   4.3	    2.7	    17.28
// 100	   200	    300	    45000
// 0.222   0.333	0.555	0.1540125


using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.Title = "09. Trapezoids";
            float a; // base1
            float b; // base2
            float h; // height
            for (int i = 0; i < 5; i++) // for five loops i.e. five checks of the code
            {
                while (true)    // to gurantee the corect input of a
                {
                    Console.Write("Please enter the value of a (base 1):    ");
                    string inputA = Console.ReadLine();
                    if (float.TryParse(inputA, out a))
                    {
                        if (a > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (true)    // to gurantee the corect input of b
                {
                    Console.Write("Please enter the value of b (base 2):    ");
                    string inputB = Console.ReadLine();
                    if (float.TryParse(inputB, out b))
                    {
                        if (b > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (true)    // to gurantee the corect input of h (height)
                {
                    Console.Write("Please enter the value of h (height):    ");
                    string inputH = Console.ReadLine();
                    if (float.TryParse(inputH, out h))
                    {
                        if (h > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                float area = ((a+b)*h)/2;
                Console.WriteLine("\n{0,10}{1,15}{2,17}{3,20}", "a", "b", "h", "area");
                string line = new String('-', 60);
                Console.WriteLine("     " + line);
                Console.WriteLine("{0,10}{1,15}{2,17}{3,20}\n", a, b, h, area);
            }
        }
    }
