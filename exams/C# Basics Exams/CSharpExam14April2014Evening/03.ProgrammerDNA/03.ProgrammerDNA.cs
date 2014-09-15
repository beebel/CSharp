// 03. Programmer DNA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ProgrammerDNA
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char start = (Console.ReadLine())[0];
        char end = 'G';

        char dot = '.';
        int charCount = 1;


        // za tselite diamanti:
        for (int c = 1; c <= length / 7; c++)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("{0}", new string(dot, (7 - charCount) / 2));

                for (int j = 1; j <= charCount; j++)
                {

                    if (start <= end)
                    {
                        Console.Write("{0}", start);
                        start++;
                    }
                    else
                    {
                        start = 'A';
                        Console.Write("{0}", start);
                        start++;
                    }
                }

                Console.Write("{0}", new string(dot, (7 - charCount) / 2));
                Console.WriteLine();

                charCount += 2;
            }

            charCount = 5;

            for (int i = 5; i <= 7; i++)
            {
                Console.Write("{0}", new string(dot, (7 - charCount) / 2));

                for (int j = 1; j <= charCount; j++)
                {

                    if (start <= end)
                    {
                        Console.Write("{0}", start);
                        start++;
                    }
                    else
                    {
                        start = 'A';
                        Console.Write("{0}", start);
                        start++;
                    }
                }

                Console.Write("{0}", new string(dot, (7 - charCount) / 2));
                Console.WriteLine();

                charCount -= 2;
            }

            charCount = 1;
        }

        // za ostatyka :

        int rem = length % 7;

        int bigRem = 0;  // must be 5 or 6

        if (rem > 4)
        {
            bigRem = rem - 4;
            rem = 4;
        }

        for (int i = 1; i <= rem; i++)
        {
            Console.Write("{0}", new string(dot, (7 - charCount) / 2));

            for (int j = 1; j <= charCount; j++)
            {

                if (start <= end)
                {
                    Console.Write("{0}", start);
                    start++;
                }
                else
                {
                    start = 'A';
                    Console.Write("{0}", start);
                    start++;
                }
            }

            Console.Write("{0}", new string(dot, (7 - charCount) / 2));
            Console.WriteLine();

            charCount += 2;
        }

        charCount = 5;

        for (int i = 1; i <= bigRem; i++)
        {
            Console.Write("{0}", new string(dot, (7 - charCount) / 2));

            for (int j = 1; j <= charCount; j++)
            {

                if (start <= end)
                {
                    Console.Write("{0}", start);
                    start++;
                }
                else
                {
                    start = 'A';
                    Console.Write("{0}", start);
                    start++;
                }
            }

            Console.Write("{0}", new string(dot, (7 - charCount) / 2));
            Console.WriteLine();

            charCount -= 2;
        }

        

    }
}
