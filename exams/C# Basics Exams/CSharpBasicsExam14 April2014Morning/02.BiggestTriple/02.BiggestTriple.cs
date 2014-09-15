// 02. Biggest Triple

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<int> numbers = new List<int>();
        string[] inputSplited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var ch in inputSplited)
        {
            int tmp = int.Parse(ch);
            numbers.Add(tmp);
        }

        int tmpThreeSum = 0;
        int biggestSum = int.MinValue;
        int index = 2;
        int startPosBiggest = 0;
        int endPosBiggest = 0;


        for (int i = 0; i < numbers.Count; i++)
        {
            tmpThreeSum += numbers[i];

            if (i == index)
            {
                if (tmpThreeSum > biggestSum)
                {
                    biggestSum = tmpThreeSum;
                    endPosBiggest = i;
                    startPosBiggest = i - 2;
                }

                tmpThreeSum = 0;
                index += 3;
            }
        }

        if (numbers.Count % 3 != 0)   
        {
            if (tmpThreeSum > biggestSum)
            {
                int rem = numbers.Count % 3; // 2
                startPosBiggest = (numbers.Count / 3) * 3; 
                endPosBiggest = numbers.Count - 1;
            }
        }

        for (int i = startPosBiggest; i <= endPosBiggest; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();

    }
}
