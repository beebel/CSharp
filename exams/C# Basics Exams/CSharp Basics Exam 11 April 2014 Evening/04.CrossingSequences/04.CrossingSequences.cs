using System;
using System.Collections.Generic;

    class CrossingSequences
    {
        static void Main()
        {
            int tribonacci1 = Convert.ToInt32(Console.ReadLine());
            int tribonacci2 = Convert.ToInt32(Console.ReadLine());
            int tribonacci3 = Convert.ToInt32(Console.ReadLine());
            int spiralInitial = Convert.ToInt32(Console.ReadLine());
            int spiralStep = Convert.ToInt32(Console.ReadLine());

            int tribonacciNext = tribonacci1 + tribonacci2 + tribonacci3;
            int spiralNext = spiralInitial + spiralStep;

            List<int> tribonacci = new List<int>();
            tribonacci.Add(tribonacci1);
            tribonacci.Add(tribonacci2);
            tribonacci.Add(tribonacci3);

            List<int> spiral = new List<int>();
            spiral.Add(spiralInitial);
            spiral.Add(spiralInitial + spiralStep);

            int result = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                result = CheckLists(tribonacci, spiral);
                if (result != 0)
                {
                    Console.WriteLine(result);
                    break;
                }
                tribonacciNext = tribonacci1 + tribonacci2 + tribonacci3;
                tribonacci1 = tribonacci2;
                tribonacci2 = tribonacci3;
                tribonacci3 = tribonacciNext;
                
                tribonacci.Add(tribonacciNext);
                spiralNext = spiralNext + spiralStep;
                spiral.Add(spiralNext);
            }
            if (result == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static int CheckLists (List<int> tribonacciList, List<int> spiralList)
        {
            int result = 0;
            foreach (var tribonacciElement in tribonacciList)
            {
                foreach (var spiralElement in spiralList)
                {
                    if (tribonacciElement == spiralElement)
                    {
                        result = tribonacciElement;
                        return result;
                    }
                }
            }
            return result;
        }
    }
