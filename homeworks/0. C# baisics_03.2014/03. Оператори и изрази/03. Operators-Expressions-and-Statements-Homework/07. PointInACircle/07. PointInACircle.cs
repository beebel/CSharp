// Problem 7.   Point in a Circle
//
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). Examples:
//
//  x	y	    inside
//------------------------
//  0	1	    true
// -2	0	    true
// -1	2	    false
// 1.5	-1	    true
//-1.5	-1.5	false
// 100	-30	    false
// 0	0	    true
// 0.2	-0.8	true
// 0.9	-1.93	false
// 1	1.655	true


using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.Title = "07. Point in a Circle";
            double x;
            double y;
            for (int i = 0; i < 10; i++) // for ten loops i.e. ten checks of the given point (x,y)
            {
                while (true)    // to gurantee the corect input of x
                {
                    Console.Write("Please enter the value of x:     ");
                    string inputX = Console.ReadLine();
                    if (double.TryParse(inputX, out x))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (true)    // to gurantee the corect input of y
                {
                    Console.Write("Please enter the value of y:     ");
                    string inputY = Console.ReadLine();
                    if (double.TryParse(inputY, out y))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                bool inside = ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 4); // x*x + y*y <= r*r // to checks if given point (x, y) is inside a circle K({0, 0}, 2) 
                Console.WriteLine("\n{0,5}{1,10}{2,30}","x","y","inside");
                string line = new String('-',60);
                Console.WriteLine(line);
                Console.WriteLine("{0,5}{1,10}{2,30}\n", x, y, inside);
            }
        }
    }
