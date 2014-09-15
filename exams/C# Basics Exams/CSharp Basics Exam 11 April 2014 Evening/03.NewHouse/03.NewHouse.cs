using System;

    class NewHouse
    {
        static void Main()
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int numFloors = inputNumber;
            int heightRoof = inputNumber / 2 + 1;
            int width = inputNumber;
            int stars = 1;
            int dashes = width - stars;
            for (int i = 0; i < heightRoof; i++)
            {
                Console.Write(new string('-', dashes /2));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashes / 2));
                Console.WriteLine();
                stars += 2;
                dashes = width - stars;
            }
            stars -= 4;
            for (int c = 0; c < inputNumber; c++)
            {
                Console.WriteLine("|" + new string('*', stars) + "|");
            }
        }
    }
