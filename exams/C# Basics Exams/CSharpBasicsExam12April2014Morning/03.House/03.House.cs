using System;

class House
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int width = input;
        int height = input;
        int middle = (width + 1) / 2;
        int index = 2;
        char star = '*';
        char dot = '.';

        Console.Write("{0}{1}{0}\n", new string(dot, middle - 1), star);
        Console.Write("{0}{1}{2}\n", new string(dot, middle - 2) + star, dot, star + new string(dot, middle - 2));
        for (int i = 2; i <= middle - 1; i++)
        {
            if ((middle - (i + 1)) == 0)
            {
                Console.WriteLine(new string(star, width));
                break;
            }
            Console.Write("{0}{1}{2}\n", new string(dot, middle - (i + 1)) + star, dot + new string(dot, index), star + new string(dot, middle - (i + 1)));
            index += 2;
        }
        for (int c = 1; c <= (height / 2); c++)
        {
            if (c == (height / 2))
            {
                Console.WriteLine("{0}{1}{0}", new string(dot, width / 4), new string(star, width - 2 * (width / 4)));
                break;
            }
            Console.WriteLine("{0}{1}{2}", new string(dot, width / 4) + star, new string (dot, width - (2 + 2 * (width / 4))), star + new string(dot, width / 4));
        }
    }
}
