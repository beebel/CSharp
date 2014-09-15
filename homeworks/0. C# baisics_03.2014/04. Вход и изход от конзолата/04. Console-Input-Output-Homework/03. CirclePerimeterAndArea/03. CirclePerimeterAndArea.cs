// Problem 3.   Circle Perimeter and Area
//
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
// with 2 digits after the decimal point. Examples:
//
//      r	   perimeter	area
//      2	   12.57	    12.57
//      3.5	   21.99	    38.48


using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Title = "03. Circle Perimeter and Area";
            double r, perimeter, area;
            for (int i = 0; i < 2; i++)         // two examples
            {
                while (true)
                {
                    Console.Write("Please enter a real, positive number for the radius r of the circle: ");
                    string input = Console.ReadLine();
                    if ((double.TryParse(input, out r)) && (r > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a correct input.");
                    }
                }
                perimeter = 2 * Math.PI * r;
                area = Math.PI * r * r;
                Console.WriteLine("\n{0,5}{1,15}{2,10}", "r", "perimeter", "area");
                string line = new string ('-', 30);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,15:F2}{2,10:F2}", r, perimeter, area);
            }   
            }
        }


