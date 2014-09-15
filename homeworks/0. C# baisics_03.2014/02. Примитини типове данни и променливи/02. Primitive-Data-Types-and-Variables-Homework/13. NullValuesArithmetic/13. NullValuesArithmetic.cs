// Problem 13.  Null Values Arithmetic
//
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            Console.Title = "13. Null Values Arithmetic";
            int intNum = 3;
            double doubleNum = 4.23434;
            Console.WriteLine("int = {0}",intNum);
            Console.WriteLine("double = {0}",doubleNum);
            int? intNull = null; //Console.WriteLine(intNull.HasValue); --> False
            Nullable<double> doubleNull = null;
            intNum = intNull.GetValueOrDefault();
            doubleNum = doubleNull.GetValueOrDefault();
            Console.WriteLine("after null value has been assigned to an integer type variable, int = {0}", intNum);
            Console.WriteLine("after null value has been assigned to a double type variable, double = {0}", doubleNum);
            intNum = intNum + 5;
            doubleNum += 1.34535356;    // doubleNum = doubleNum + 1.34535356
            Console.WriteLine("int + 5 = {0}", intNum);
            Console.WriteLine("double + 1.34535356 = {0}", doubleNum);
            //intNum = intNum + null;
            //Console.WriteLine(intNum); --> cause an error
        }
    }
