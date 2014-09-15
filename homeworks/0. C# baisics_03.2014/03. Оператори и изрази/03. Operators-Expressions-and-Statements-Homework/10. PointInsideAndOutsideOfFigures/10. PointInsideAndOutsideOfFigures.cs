// Problem 10.  Point Inside a Circle & Outside of a Rectangle
//
// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
//
//  x	    y	    inside K & outside of R
//--------------------------------------------
//  1	    2	    yes
//  2.5	    2	    no
//  0	    1	    no
//  2.5	    1	    no
//  2	    0	    no
//  4	    0	    no
//  2.5	    1.5	    no
//  2	    1.5	    yes
//  1	    2.5	    yes
//  -100	-100    no


using System;

    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            Console.Title = "10. Point Inside a Circle & Outside of a Rectangle";
            float x;
            float y;
            for (int i = 0; i < 10; i++) // for ten loops i.e. ten checks of the given point (x,y)
            {
                while (true)    // to gurantee the corect input of x
                {
                    Console.Write("Please enter the value of x:     ");
                    string inputX = Console.ReadLine();
                    if (float.TryParse(inputX, out x))
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
                    if (float.TryParse(inputY, out y))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                bool insideCircle = ((Math.Pow((x - 1), 2) + (Math.Pow((y - 1), 2))) <= (1.5 * 1.5)); // (x - 1)^2 + (y - 1)^2 <= r*r // to checks if given point (x, y) is inside a circle K({1, 1}, 1,5)
                bool outsideRectangle = (y > 1); // to be outside of the rectagle, because it's top side is y = 1
                bool insideOutsideFigures = insideCircle && outsideRectangle; // inside K & outside of R 
                string result = insideOutsideFigures ? "yes" : "no"; // ternary operator 
                Console.WriteLine("\n{0,5}{1,10}{2,30}", "x", "y", "inside K & outside of R");
                string line = new String('-', 60);
                Console.WriteLine(line);
                Console.WriteLine("{0,5}{1,10}{2,30}\n", x, y, result);
            }
        }
    }
