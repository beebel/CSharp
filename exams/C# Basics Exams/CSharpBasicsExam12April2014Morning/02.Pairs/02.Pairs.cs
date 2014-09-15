using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Pairs
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number = 0;
        int sumNextPair = 0;
        int maxSumPairs = 0;
        int maxDifference = 0;
        string text = null;
        bool equal = true;

        while (true)
        {
            int readString = Console.Read();
            if (readString != 32)
            {
                text += (char)readString;                            
            }
            if (readString == 32)
            {
                number = Convert.ToInt32(text);
                numbers.Add(number);
                text = null;
            }
            if (readString == 10)
            {
                number = Convert.ToInt32(text);
                numbers.Add(number);
                break;
            }
        }
        maxSumPairs = numbers[0] + numbers[1];
        if (numbers.Count == 2)
        {
            if (numbers[0] != numbers[1])
            {
                equal = false;
                Console.WriteLine("No, maxdiff={0}", Math.Abs(numbers[0] - numbers[1]));
            }
            equal = false;                                          // here actually equal is true
            Console.WriteLine("Yes, value={0}", maxSumPairs);
        }
        else
        {
            for (int i = 2; i < numbers.Count; i++)     
            {
                sumNextPair += numbers[i];          
                if (i % 2 == 1)                    
                {
                    if (sumNextPair != maxSumPairs)     
                    {
                        equal = false;
                        maxDifference = Math.Abs(maxSumPairs - sumNextPair);
                        int sumPreviousPair = sumNextPair;
                        sumNextPair = 0;
                        for (int p = i; p < numbers.Count; p++)
                        {
                            sumNextPair += numbers[p];
                            if (p % 2 == 1)
                            {
                                maxDifference = Math.Max(sumPreviousPair, sumNextPair);
                            }
                        }
                    }
                    else
                    {
                        sumNextPair = 0;            
                    }
                }
            }
        }
        if (equal)
        {
            Console.WriteLine("No, maxdiff={0}", maxDifference);
        }
        if (equal == true)
        {
            Console.WriteLine("Yes, value={0}", maxSumPairs);
        }    
    } 
}
