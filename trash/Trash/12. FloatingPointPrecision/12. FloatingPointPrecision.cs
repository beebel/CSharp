using System;

    class Program
    {
        static void Main()
        {
            float a = 10000000f;
            float b = 1f;
            float sum = a + b;
            Console.WriteLine(sum);
            Console.WriteLine(sum.ToString("F0"));
            a = 1000000f;
            sum = a + b;
            Console.WriteLine(sum);
            Console.WriteLine(sum.ToString("F0"));
            //http://en.wikipedia.org/wiki/Single-precision_floating-point_format
        }
    }

