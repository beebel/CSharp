// 03. Sand Glass

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SandGlass
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        char dot = '.';
        char star = '*';

        Console.Write("{0}", new string(star, height));
        Console.WriteLine();

        for (int i = 1; i <= height/ 2; i++)
        {
            Console.Write("{0}{1}{0}", new string(dot, i), new string(star, height - 2 * i));
            Console.WriteLine();
        }

        for (int i = (height - (height/2 + 1)); i >= 1 ; i--)
        {
            Console.Write("{0}{1}{0}", new string(dot, i - 1), new string(star, height - 2 * (i - 1)));
            Console.WriteLine();
        }
    }
}
