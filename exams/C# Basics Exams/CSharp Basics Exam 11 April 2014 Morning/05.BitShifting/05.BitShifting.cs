using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BitShifting
{
    class Program
    {
        static void Main()
        {
            ulong num = Convert.ToUInt64(Console.ReadLine());
            string binaryNumString = Convert.ToString((long)num, 2);
            ulong binaryNum = Convert.ToUInt64(binaryNumString);
            int n = Convert.ToInt32(Console.ReadLine());
            int pos1 = 0;
            ulong index = 1;
            ulong mask = 1;
            List<int> positionsOf1 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                ulong sieve = Convert.ToUInt64(Console.ReadLine());
                string binarySieveString = Convert.ToString((long)sieve, 2);
                ulong binarySieve = Convert.ToUInt64(binarySieveString);
                if (num != 1)
                {
                    num = num / 2;
                    pos1++;
                }
                else
                {
                    pos1 = 1;
                    while (num != 1)
                    {
                        while (index < num)
                        {
                            index *= 2;
                            pos1++;
                        }
                        positionsOf1.Add(pos1);
                        pos1 = 1;
                        num = num - index;
                        index = 1;
                    }
                    positionsOf1.Add(0);
                    pos1 = 0;
                }
                ulong bitsFallThrough = binaryNum ^ binarySieve;
                mask = mask << positionsOf1[i];
                bitsFallThrough = bitsFallThrough ^ mask;
                binaryNum = bitsFallThrough;
            }
            Console.WriteLine(binaryNum);
        }
    }
}
