// Problem 3.	Primes in Given Range

// Write a method that calculates all prime numbers in given range and returns them as list of integers:

// static List<int> FindPrimesInRange(startNum, endNum)
// {
//     …
// }

// Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line)
// and prints all primes in their range, separated by a comma.
// Examples:

//  Start number              Output
//  End number	                                  

//  0
//  10	                      2, 3, 5, 7

//  5
//  11	                      5, 7, 11

//  100 	                  101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 
//  200                       167, 173, 179, 181, 191, 193, 197, 199

//  250
//  950	                      251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 
//                            353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 
//                            457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 
//                            571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 
//                            673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 
//                            797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 
//                            911, 919, 929, 937, 941, 947

// 100
// 50	                      (empty list)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.Title = "03. Primes In Given Range";

            Console.Write("Enter the starting number:  ");
            int startNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number:  ");
            int endNum = int.Parse(Console.ReadLine());


            List<int> primesInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine();

            for (int i = 0; i < primesInRange.Count - 1; i++)
            {
                Console.Write("{0}, ", i);
            }
            Console.Write(primesInRange.Last());
            Console.WriteLine("\n");
        }






        static int IsPrime(int n)
        {
            bool isPrime = true;
            int result;

            if (n == 0 || n == 1)
            {
                isPrime = false;
            }

            else
            {
                for (int i = 2; i < n; i++)
                {
                    for (int del = 2; del < n; del++)
                    {
                        if (n % del == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == false)
                    {
                        break;
                    }
                }
            }

            result = (isPrime == true ? n : -1);
            return result;
        }




        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesToEndNum = new List<int>();

            for (int i = 0; i < endNum; i++)
            {
                if (IsPrime(i) != -1)
                {
                    primesToEndNum.Add(i);
                }
                
            }

            //foreach (var prime in primesToEndNum)
            //{
            //    if (prime < startNum)
            //    {
            //        primesToEndNum.Remove(prime);
            //    }
            //}

            return primesToEndNum;
        }

    }
