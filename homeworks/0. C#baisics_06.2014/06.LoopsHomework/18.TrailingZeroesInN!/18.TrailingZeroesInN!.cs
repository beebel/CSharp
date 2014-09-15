// Problem 18.*  Trailing Zeroes in N!

// Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your 
// program should work well for very big numbers, e.g. n=100000. Examples:

//          n	        trailing zeroes of n!	    explaination
//          10	        2	                        3628800
//          20	        4	                        2432902008176640000
//          100000	    24999	                    think why

// http://www.purplemath.com/modules/factzero.htm


using System;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. Examples:
// |      n | trailing zeroes of n! | explaination        |
// |     10 |                     2 | 3628800             |
// |     20 |                     4 | 2432902008176640000 |
// | 100000 |                 24999 | think why           |

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter integer number n (0 <= n): ");
        long n;
        bool nParse = long.TryParse(Console.ReadLine(), out n);

        if (!nParse || n < 0)
        {
            Console.WriteLine("invalid input");
            return;
        }

        long trailinZeroes = 0;
        int power = 1;

        do
        {
            trailinZeroes += n / (long)Math.Pow(5, power);
            power++;

        } while (Math.Pow(5, power) <= n);

        Console.WriteLine(trailinZeroes);
    }
}

// и моето решение, не работи за num >= 100000:




//using System;
//using System.Numerics;

//class TrailingZeroesInN
//{
//    static void Main()
//    {
//        Console.Title = "18.* Trailing Zeroes in N!";

//        int num;
//        int zeroCounter = 0;
//        BigInteger fact;

//        for (int t = 1; t <= 3; t++)            // for 3 tests
//        {
//            Console.WriteLine("test{0}:\n", t);

//            while (true)
//            {
//                Console.Write("Enter an integer number:  ");

//                bool check = int.TryParse(Console.ReadLine(), out num);
//                if (check)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("\nInvalid input- not an integer number!\n");
//                }
//            }

//            fact = factorial(num);

//            while (true)
//            {
//                if (fact % 10 == 0)
//                {
//                    fact = fact / 10;
//                    zeroCounter++;
//                }
//                else
//                {
//                    break;
//                }
//            }

//            Console.WriteLine("\n{0}\n\n\n", zeroCounter);

//            zeroCounter = 0;
//        }
//    }

//    private static BigInteger factorial(int n)
//    {
//        BigInteger factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }
//        return factorial;
//    }
//}
