// Problem 2.	 Float or Double?

// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
// 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and 
// print them to ensure no precision is lost. 

using System;

    class FloatOrDouble
    {
        static void Main()
        {
            Console.Title = "02. Float or Double";
            double firstVar = 34.567839023;
            float secondVar = 12.345f;
            double thirdVar = 8923.1234857f;
            float fourthVar = 3456.091f;
            Console.WriteLine("double: {0}\nfloat: {1}\ndouble: {2}\nfloat: {3}\n", 
                                                                          firstVar, secondVar, thirdVar, fourthVar);
        }
    }

