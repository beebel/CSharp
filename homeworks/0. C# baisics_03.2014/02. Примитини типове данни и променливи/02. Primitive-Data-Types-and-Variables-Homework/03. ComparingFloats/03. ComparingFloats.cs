// Problem 3.   Comparing Floats
//
// Write a program that safely compares floating-point numbers with precision eps = 0.000001. 
// Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature
// of the floating-point arithmetic. Therefore, we assume two numbers are equal
// if they are more closely to each other than a fixed constant eps. Examples: 
//
// Number a	   Number b	    Equal (with precision eps=0.000001)	   Explanation
// 5.3	        6.01	    false	                               The difference of 0.71 is too big (> eps)
// 5.00000001	5.00000003	true	                               The difference 0.00000002 < eps
// -0.0000007	0.00000007	true	                               The difference 0.00000077 < eps
// -4.999999	-4.999998	false	                               Border case. The difference 0.000001 == eps. We consider the numbers are different.


using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Title = "03. Comparing Floats";
        bool isFloatNum1;
        float num1;
        for (int i = 0; i < 4; i++) // for 4 examples
        {
            while (true)    // to guarantee the correct input of num1 
            {
                Console.Write("Please, enter the first floating point number:   ");
                string firstFloatNum = Console.ReadLine();
                isFloatNum1 = float.TryParse(firstFloatNum, out num1);
                if (isFloatNum1 == true)
                {
                    break;
                }
            }
            bool isFloatNum2;
            float num2;
            while (true)    // to guarantee the correct input of num2 
            {
                Console.Write("Please, enter the second floating point number:  ");
                string secondFloatNum = Console.ReadLine();
                isFloatNum2 = float.TryParse(secondFloatNum, out num2);
                if (isFloatNum2 == true)
                {
                    break;
                }
            }
            float eps = 0.000001f;
            float dif = Math.Abs(num1 - num2);  // absolute value
            int borderCase = dif.CompareTo(eps);
            if (borderCase == 0)
            {
                Console.WriteLine("\nBorder case. The difference 0.000001 == eps. We consider the numbers are different.\n");
            }
            else
            {
                bool areEqual = (dif < eps);
                if (areEqual == true)
                {
                    Console.WriteLine("\n{0}\n\nThe both numbers are equal, because the difference of {1} between them is too small.\n"
                        , areEqual, dif);
                }
                else
                {
                    Console.WriteLine("\n{0}\n\nThe both numbers are not equal, because the difference of {1} between them is too big."
                        , areEqual, dif);
                }
            }    
        }
    }
}
