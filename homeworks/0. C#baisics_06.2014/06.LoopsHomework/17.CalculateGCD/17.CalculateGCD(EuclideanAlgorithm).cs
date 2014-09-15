// Problem 17.*  Calculate GCD

// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the 
// Euclidean algorithm (find it in Internet). Examples:

//      a	    b	    GCD(a, b)
//      3	    2	    1
//      60	    40	    20
//      5	    -15	    5

// http://bg.wikipedia.org/wiki/%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D1%8A%D0%BC_%D0%BD%D0%B0_%D0%95%D0%B2%D0%BA%D0%BB%D0%B8%D0%B4

using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Title = "17.* Calculate GCD";

            int num1, num2;
            int a = 0;
            int b = 0;
            int GCD = 0;
            int rem = 1;

            for (int t = 1; t <= 3; t++)        // for 3 tests
            {
                Console.WriteLine("test{0}:\n", t);

                while (true)
                {
                    Console.Write("Enter the first integer number:  ");

                    bool check = int.TryParse(Console.ReadLine(), out num1);
                    if (check)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input for number 1!\n");
                    }
                }

                while (true)
                {
                    Console.Write("Enter the second integer number:  ");

                    bool check = int.TryParse(Console.ReadLine(), out num2);
                    if (check)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input for number 2!\n");
                    }
                }

                num1 = Math.Abs(num1);
                num2 = Math.Abs(num2);

                if (num1 > num2)
                {
                    a = num1;
                    b = num2;
                }
                if (num1 < num2)
                {
                    a = num2;
                    b = num1;
                }
                if (num1 == num2)
                {
                    GCD = a;

                    Console.WriteLine("\n\n{0}", GCD);
                    Console.WriteLine("\n\n\n");
                    continue;
                }
                if (num1 == 0)
                {
                    GCD = num2;

                    Console.WriteLine("\n\n{0}", GCD);
                    Console.WriteLine("\n\n\n");
                    continue;
                }
                if (num2 == 0)
                {
                    GCD = num1;

                    Console.WriteLine("\n\n{0}", GCD);
                    Console.WriteLine("\n\n\n");
                    continue;
                }


                 
                if (a % b == 0)
                {
                    GCD = b;

                    Console.WriteLine("\n\n{0}", GCD);
                    Console.WriteLine("\n\n\n");
                    continue;
                }
                else
                {
                    while (rem != 0)                // 252 % 105 = 42;  a = 105; b = 42;  rem = 42; GCD = 105
                    {                               // 105 % 42 = 21;   a = 42;  b = 21;  rem = 21; GCD = 42
                        rem = a % b;               //  42 % 21 = 0;     a = 21;  b = 0;   rem = 0;  GCD = 21
                        a = b;                      // 21 % 0 = error!   
                        b = rem;

                        GCD = a;
                    }
                }

                Console.WriteLine("\n\n{0}", GCD);
                Console.WriteLine("\n\n\n");

                rem = 1;
            }
        }
    }
