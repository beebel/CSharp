using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Triangle
    {
        static void Main()
        {
            double xA = Convert.ToInt32(Console.ReadLine());
            double yA = Convert.ToInt32(Console.ReadLine());
            double xB = Convert.ToInt32(Console.ReadLine());
            double yB = Convert.ToInt32(Console.ReadLine());
            double xC = Convert.ToInt32(Console.ReadLine());
            double yC = Convert.ToInt32(Console.ReadLine());

            bool triangle = false;
            double p = 0d;
            double area = 0d;
            double c = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            double a = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
            double b = Math.Sqrt(Math.Pow((xA - xC), 2) + Math.Pow((yA - yC), 2));

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                triangle = true;
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            }
            Console.WriteLine("{0}", triangle ? "Yes": "No");
            Console.WriteLine("{0:0.00}", triangle ? area : c);           
        }
    }
