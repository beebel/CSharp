// Problem 01.   Exchange if Greater
//
// Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is
// greater than the second one. As a result print the values a and b, separated by a space. Examples:
// 
// a	 b	    result
// 5	 2	    2 5
// 3	 4	    3 4
// 5.5	 4.5	4.5 5.5


using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Title = "01. Exchange if Greater";
            int a, b, bigger, smaller;
            for (int i = 0; i < 3; i++)   // 3 examples
            {
                while (true)
                {
                    Console.Write("Please enter an integer number for a: ");
                    string inputA = Console.ReadLine();
                    if (int.TryParse(inputA, out a))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not a valid integer.");
                    }
                }
                while (true)
                {
                    Console.Write("Please enter an integer number for b: ");
                    string inputB = Console.ReadLine();
                    if (int.TryParse(inputB, out b))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is not a valid integer.");
                    }
                }
                if (a > b)
                {
                    bigger = a;
                    smaller = b;
                }
                else
                {
                    bigger = b;
                    smaller = a;
                }
                Console.WriteLine("\n{0,10}{1,5}{2,10}", "a", "b", "result");
                string line = new string ('=', 24);
                Console.WriteLine("     " + line);
                Console.WriteLine("{0,10}{1,5}{2,5} {3}", a, b, smaller, bigger);
                Console.WriteLine();
            }
        }
    }
