// 03. Arrow

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Arrow
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        
        int armsArrow = width / 2;
        int lineLength = 2 * armsArrow + width;

        char dot = '.';
        char hashtag = '#';

        Console.Write(new string(dot, armsArrow) + new string(hashtag, width) + new string(dot, armsArrow));
        
        Console.WriteLine();

        for (int i = 0; i < width - 2; i++)
        {
            Console.Write(new string(dot, armsArrow) + hashtag + new string(dot, width - 2) + hashtag + new string(dot, armsArrow));
            Console.WriteLine();
        }

        Console.Write(new string(hashtag, armsArrow + 1) + new string(dot, width - 2) + new string(hashtag, armsArrow + 1));
        Console.WriteLine();

        for (int i = 1; i <= width - 2; i++)
        {
            Console.Write(new string(dot, i) + hashtag + new string(dot, lineLength - (i + 1) * 2) + hashtag + new string(dot, i));
            Console.WriteLine();
        }

        Console.Write(new string(dot, lineLength / 2) + hashtag + new string(dot, lineLength / 2));
        Console.WriteLine();

    }
}
