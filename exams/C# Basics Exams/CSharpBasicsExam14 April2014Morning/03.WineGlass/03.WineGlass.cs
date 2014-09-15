using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char backslash = '\\';
        char slash = '/';
        char star = '*';
        char dot = '.';
        char vertical = '|';
        char dash = '-';

        Console.Write(backslash + new string(star, n - 2) + slash);
        Console.WriteLine();

        for (int i = 1; i < n / 2; i++)
        {
            Console.Write(new string(dot, i) + backslash + new string(star, n - 2 - i * 2) + slash + new string(dot, i));
            Console.WriteLine();
        }

        if (n < 12)
        {
            for (int j = 0; j < n / 2 - 1; j++)
            {
                Console.Write("{0}{1}{0}", new string(dot, ((n - 2) / 2)), new string(vertical, 2));
                Console.WriteLine();
            }
            Console.Write(new string(dash, n));
        }

        else
        {
            for (int j = 0; j < n / 2 - 2; j++)
            {
                Console.Write("{0}{1}{0}", new string(dot, (n - 2) / 2), new string(vertical, 2));
                Console.WriteLine();
            }
            Console.WriteLine(new string(dash, n));
            Console.WriteLine(new string(dash, n));
        }

        Console.WriteLine();
    }
}
