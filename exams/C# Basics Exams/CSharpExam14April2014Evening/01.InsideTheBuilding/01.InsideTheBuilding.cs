// 01. Inside TheBuilding

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                int tmpX = int.Parse(Console.ReadLine());
                int tmpY = int.Parse(Console.ReadLine());

                if (((tmpX <= 3 * h) && (tmpX >= 0) && (tmpY >= 0) && (tmpY <= h)) || 
                     ((tmpX >= h) && (tmpX <= 2 * h) && (tmpY >= h) && (tmpY <= 4 * h)))

                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
