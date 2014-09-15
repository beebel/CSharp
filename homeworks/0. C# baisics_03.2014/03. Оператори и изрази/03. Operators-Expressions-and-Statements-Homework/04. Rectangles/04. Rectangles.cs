// Problem 4.   Rectangles
//
// Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//
// width	height	perimeter	area
//  3	      4	      14	    12
//  2.5	      3	      11	    7.5
//  5	      5	      20	    25


using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Title = "04. Rectangles";
            float width;
            float height;
            for (int i = 0; i < 3; i++) // for three loops i.e. three calculations of rectangle’s perimeter and area 
            {
                while (true)    // to gurantee a corect input of the width
                {
                    Console.Write("Please enter the width of the rectangle:     ");
                    string inputWidth = Console.ReadLine();
                    bool check = float.TryParse(inputWidth, out width);
                    if (check == true)
                    {
                        if ((width > 0) && (width <= float.MaxValue)) // a positive float
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input for width!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input for width!");
                    }
                }
                while (true)    // to gurantee a corect input of the height
                {
                    Console.Write("Please enter the height of the rectangle:    ");
                    string inputHeight = Console.ReadLine();
                    bool check = float.TryParse(inputHeight, out height);
                    if (check == true)
                    {
                        if ((height > 0) && (height <= float.MaxValue)) // a positive float
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input for height!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input for height!");
                    }
                }
                float perimeter = 2 * (height + width);
                float area = height * width;
                Console.WriteLine("\n{0,5}{1,10}{2,15}{3,16}", "width", "height", "perimeter", "area");
                string line = new String('-', 50);
                Console.WriteLine(line);
                Console.WriteLine("{0,5}{1,10}{2,15}{3,16}\n", width, height, perimeter, area);
            }
        }
    }
