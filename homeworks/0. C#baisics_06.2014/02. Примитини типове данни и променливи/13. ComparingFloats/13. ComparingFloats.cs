// Problem 13.*     Comparing Floats
//
// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
// Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature 
// of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely
// to each other than a fixed constant eps. Examples:

// Number a	    Number b    Equal (with precision eps=0.000001)     Explanation
// 5.3	        6.01	    false	                                The difference of 0.71 is too big (> eps)
// 5.00000001	5.00000003	true	                                The difference 0.00000002 < eps
// 5.00000005	5.00000001	true	                                The difference 0.00000004 < eps
// -0.0000007	0.00000007	true	                                The difference 0.00000077 < eps
// -4.999999	-4.999998	false                                   Border case. The difference 0.000001 == eps.
//                                                                  We consider the numbers are different. 
// 4.999999	    4.999998	false                                   Border case. The difference 0.000001 == eps. 
//                                                                  We consider the numbers are different.

using System;


class ComparingFloats
{
    static void Main()
    {
        Console.Title = "13.* Comparing Floats";
        bool isDoubleNumA;
        double numA;
        for (int i = 0; i < 6; i++) // for 6 examples
        {
            while (true)    // to guarantee the correct input of numA 
            {
                Console.Write("Please, enter the first floating point number:   ");
                string firstNum = Console.ReadLine();
                isDoubleNumA = double.TryParse(firstNum, out numA);
                if (isDoubleNumA == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input- not a double.");
                }
            }
            bool isDoubleNumB;
            double numB;
            while (true)    // to guarantee the correct input of numB 
            {
                Console.Write("Please, enter the second floating point number:  ");
                string secondNum = Console.ReadLine();
                isDoubleNumB = double.TryParse(secondNum, out numB);
                if (isDoubleNumB == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input- not a double.");
                }
            }
            double eps = 0.000001;
            double dif = Math.Abs(numA - numB);  // absolute value
            if (dif < eps)
            {
                Console.WriteLine("\ntrue\n\nThe difference {0:0.00000000} < eps\n", dif);
            }
            else if (dif > eps)
            {
                Console.WriteLine("\nfalse\n\nThe difference of {0:0.00000000} is too big ( > eps)\n", dif);
            }
            else if (dif == eps)   
            {
                Console.WriteLine("\nBorder case. The difference 0.000001 == eps. We consider the numbers are different.\n");
            }
        }
    }
}