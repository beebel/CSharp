// Problem 12.   Null Values Arithmetic
//
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console. Try to add some number or the null literal to these variables 
// and print the result.

using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            Console.Title = "12. Null Values Arithmetic";
            int intNum = 3;
            double doubleNum = 4.23434;
            Console.WriteLine("intNum = {0}", intNum);
            Console.WriteLine("doubleNum = {0}", doubleNum);
            int? intNull = null;        //Console.WriteLine(intNull.HasValue); --> False
            Nullable<double> doubleNull = null;
            Console.WriteLine("intNull:     {0}", intNull);
            Console.WriteLine("doubleNull:  {0}", doubleNull);
            intNull = intNull + 10;
            doubleNull = doubleNull * 12;
            Console.WriteLine("intNull + 10:    {0}", intNull);
            Console.WriteLine("doubleNull * 12: {0}", doubleNull);
            intNum = intNull.GetValueOrDefault();
            doubleNum = doubleNull.GetValueOrDefault();
            Console.WriteLine("\nafter null value has been assigned to an integer type variable, intNum = {0}", intNum);
            Console.WriteLine("after null value has been assigned to a double type variable, doubleNum = {0}\n", doubleNum);
            intNum = intNum + 5;
            doubleNum += 1.34535356;    // doubleNum = doubleNum + 1.34535356
            Console.WriteLine("intNum + 5 = {0}", intNum);
            Console.WriteLine("doubleNum + 1.34535356 = {0}\n", doubleNum);
            //intNum = intNum + null;
            //Console.WriteLine(intNum); --> cause an error
        }
    }

