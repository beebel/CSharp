// Problem 4.   Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them. Try to implement this 
// without if statements. Examples:
//
//      a	    b	    Greater
// =============================
//      5	    6	    6
//      10	    5	    10
//      0	    0	    0
//      -5	    -2	    -2
//      1.5	    1.6	    1.6


using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Title = "04. Number Comparer";
            for (int i = 0; i < 5; i++)             // five examples
            {
                Console.Write("Please enter the fist number: ");
                string input1 = Console.ReadLine();
                double a = double.Parse(input1);
                Console.Write("Please enter the second number: ");
                string input2 = Console.ReadLine();
                double b = double.Parse(input2);
                double greater = (a > b ? a : b);
                Console.WriteLine("\n{0,5}{1,15}{2,20}", "a", "b", "greater");
                string line = new string('-', 40);
                Console.WriteLine("  " + line);
                Console.WriteLine("{0,5}{1,15}{2,20}\n", a, b, greater);
            }
            
        }
    }
