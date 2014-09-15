// 02. Odd / Even Elements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<decimal> inputNums = new List<decimal>();
        List<decimal> oddNums = new List<decimal>();
        List<decimal> evenNums = new List<decimal>();

        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var num in numbers)
        {
            inputNums.Add(decimal.Parse(num));
        }

        int index = 1;

        for (int i = 0; i < inputNums.Count; i++)
        {

            if (index % 2 == 1)
            {
                oddNums.Add(inputNums[i]);
            }
            else
            {
                evenNums.Add(inputNums[i]);
            }

            index++;
        }

        if (inputNums.Count == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }

        else if (inputNums.Count == 1)
        {
            double oddNumsSum = (double)oddNums.Sum();
            double oddNumsMin = (double)oddNums.Min();
            double oddNumsMax = (double)oddNums.Max();
            
            Console.WriteLine("OddSum={0:G0}, OddMin={1:G0}, OddMax={2:G0}, EvenSum=No, EvenMin=No, EvenMax=No",
                oddNumsSum, oddNumsMin, oddNumsMax);
        }

        else
        {
            double oddNumsSum = (double)oddNums.Sum();
            double oddNumsMin = (double)oddNums.Min();
            double oddNumsMax = (double)oddNums.Max();
            double evenNumsSum = (double)evenNums.Sum();
            double evenNumsMin = (double)evenNums.Min();
            double evenNumsMax = (double)evenNums.Max();

            Console.WriteLine("OddSum={0:G0}, OddMin={1:G0}, OddMax={2:G0}, EvenSum={3:G0}, EvenMin={4:G0}, EvenMax={5:G0}",  // {...:G0} Remove trailing zeros
                oddNumsSum, oddNumsMin, oddNumsMax, evenNumsSum, evenNumsMin, evenNumsMax);
        }
    }
}

