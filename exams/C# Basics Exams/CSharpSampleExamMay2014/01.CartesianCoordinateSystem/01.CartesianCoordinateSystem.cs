// 01. Cartesian Coordinate System

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CartesianCoordinateSystem
{
    static void Main()
    {

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        int result;

        if (x > 0)
        {
            if (y > 0)
            {
                result = 1;
                Console.WriteLine(result);
            }
            else if (y == 0)
            {
                result = 6;
                Console.WriteLine(result);
            }
            else  // y < 0
            {
                result = 4;
                Console.WriteLine(result);
            }
        }
        else if (x < 0)
        {
            if (y > 0)
            {
                result = 2;
                Console.WriteLine(result);
            }
            else if (y < 0)
            {
                result = 3;
                Console.WriteLine(result);
            }
            else // y = 0
            {
                result = 6;
                Console.WriteLine(result);
            }
        }
        else // x = 0
        {
            if (y > 0)
            {
                result = 5;
                Console.WriteLine(result);
            }
            else if (y < 0)
            {
                result = 5;
                Console.WriteLine();
            }
            else // y = 0
            {
                result = 0;
                Console.WriteLine(result);
            }
        }
    }
}
