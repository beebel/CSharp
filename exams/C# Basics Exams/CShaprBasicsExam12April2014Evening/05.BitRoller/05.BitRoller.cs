// 05. Bit Roller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class BitRoller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fPos = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());


            List<char> bits = Convert.ToString(n, 2).PadLeft(19, '0').ToList();
            char chFPos = bits[19 - fPos - 1];

            
            for (int i = 0; i < r; i++)
			{
                int remN = n % 2;  //  pri n >> 1 ostataka kojto se gubi
                n = n / 2;

                char rem = remN.ToString()[0];
                
                bits.RemoveAt(18);
                bits.Reverse();
                bits.Add(rem);
                bits.Reverse(); // rotation of bits

                bits[19 - fPos] = bits[19 - fPos - 1];  // for the fixed position
                bits[19 - fPos - 1] = chFPos;

			}

            string result = null;

            foreach (var ch in bits)
            {
                result += ch;
            }

            int resultToDec = Convert.ToInt32(result, 2);

            Console.WriteLine(resultToDec);
        }
    }
