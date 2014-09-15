using System;

class FirTree
{

    static void Main()
    {

        Console.Write("Enter num: ");

        int num = int.Parse(Console.ReadLine());

        int star = 1;

        int dot = num - 2;

        Console.WriteLine();

        for (int i = 1; i < num; i++)
        {

            Console.Write(new string('.', dot));

            Console.Write(new string('*', star));

            Console.Write(new string('.', dot));

            Console.WriteLine();

            star += 2;

            dot--;

        }

        int newDot = num - 2;

        Console.WriteLine(new string('.', newDot) + new string('*', 1) + new string('.', newDot));
        Console.WriteLine();

    }

}