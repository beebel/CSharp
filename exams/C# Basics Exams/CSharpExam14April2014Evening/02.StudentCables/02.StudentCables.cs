// 02. Student Cables

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StudentCables
{
    static void Main()
    {
        int cablesN = int.Parse(Console.ReadLine());

        int joinedCable = 0;
        int countUsedCables = 0;


        for (int i = 0; i < cablesN; i++)
        {
            int tmpCableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure != "centimeters")
            {
                tmpCableLength = tmpCableLength * 100;
            }

            if (tmpCableLength >= 20)
            {
                countUsedCables++;
                joinedCable += tmpCableLength;
            }

        }

        int conections = (countUsedCables - 1);

        joinedCable = joinedCable - conections * 3;



        int studentCables = joinedCable / 504;
        int rem = joinedCable % 504;

        Console.WriteLine(studentCables);
        Console.WriteLine(rem);
    }
}

