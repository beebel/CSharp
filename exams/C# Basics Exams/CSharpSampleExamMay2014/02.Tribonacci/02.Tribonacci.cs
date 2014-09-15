// 02. Tribonacci

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

    class Tribonacci
    {
        static void Main()
        {

            BigInteger trib1 = BigInteger.Parse(Console.ReadLine());
            BigInteger trib2 = BigInteger.Parse(Console.ReadLine());
            BigInteger trib3 = BigInteger.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            

            if (n == 1)
            {
                Console.WriteLine(trib1);
            }
            else if (n == 2)
            {
                Console.WriteLine(trib2);
            }
            else if (n == 3)
            {
                Console.WriteLine(trib3);
            }
            else
            {
                BigInteger tmpNext = 0;

                for (int i = 1; i <= n - 3; i++)
                {
                    tmpNext = TribNext(trib1, trib2, trib3);

                    trib1 = trib2;
                    trib2 = trib3;
                    trib3 = tmpNext;
                }

                Console.WriteLine(tmpNext);
            }
        } 

        static BigInteger TribNext (BigInteger a, BigInteger b, BigInteger c)
        {
            BigInteger nextNum = a + b + c;

            return nextNum;
        }
    }
