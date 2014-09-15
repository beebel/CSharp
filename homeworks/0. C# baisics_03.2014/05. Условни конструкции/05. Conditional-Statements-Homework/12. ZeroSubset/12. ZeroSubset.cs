// Problem 12.*     Zero Subset

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
// Assume that repeating the same subset several times is not a problem. Examples:

   //     numbers	            result
   //=========================================
   //     3 -2 1 1 8	      -2 + 1 + 1 = 0
   //     3 1 -7 35 22	      no zero subset

   //                         1 + -1 = 0
   //     1 3 -4 -2 -1        1 + 3 + -4 = 0
   //                         3 + -2 + -1 = 0
 
   //                         1 + -1 = 0      
   //     1 1 1 -1 -1	      1 + 1 + -1 + -1 = 0
   //                         1 + -1 + 1 + -1 = 0
   //                         …

   //     0 0 0 0 0	          0 + 0 + 0 + 0 + 0 = 0

// Hint: you may check for zero each of the 32 subsets with 32 if statements.

using System;

    class ZeroSubset
    {
        static void Main()
        {
            Console.Title = "12.* Zero Subset";
            int a, b, c, d, e;
            int result = 0;
            while (true)
            {
                Console.Write("Please enter the first integer number for a: ");
                int? first = trueInt(Console.ReadLine());
                if (first != null)
                {
                    a = first.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for a!");
                }
            }
            while (true)
            {
                Console.Write("Please enter the first integer number for b: ");
                int? second = trueInt(Console.ReadLine());
                if (second != null)
                {
                    b = second.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for b!");
                }
            }
            while (true)
            {
                Console.Write("Please enter the first integer number for c: ");
                int? third = trueInt(Console.ReadLine());
                if (third != null)
                {
                    c = third.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for c!");
                }
            }
            while (true)
            {
                Console.Write("Please enter the first integer number for d: ");
                int? four = trueInt(Console.ReadLine());
                if (four != null)
                {
                    d = four.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for d!");
                }
            }
            while (true)
            {
                Console.Write("Please enter the first integer number for e: ");
                int? fifth = trueInt(Console.ReadLine());
                if (fifth != null)
                {
                    e = fifth.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for e!");
                }
            }
            if ((a == 0) && (b == 0) && (c == 0) && (d == 0) && (e == 0))
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }
            //a
            if (a + b + c + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }
            if (a + b + c + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            if (a + b + c + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }

            if (a + b + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            }
            if (a + c + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }
            if (a + b + c == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }
            if (a + b + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }
            if (a + b + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }
            if (a + c + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }
            if (a + c + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }
            if (a + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            }
            if (a + b == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", a, b);
            }
            if (a + c == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", a, c);
            }
            if (a + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", a, d);
            }
            if (a + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", a, e);
            }

            //b
            if (b + c + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }
            if (b + c + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }
            if (b + c + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            }
            if (b + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }
            if (b + c == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", b, c);
            }
            if (b + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", b, d);
            }
            if (b + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", b, e);
            }

            //c
            if (c + d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
            if (c + d == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            if (c + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", c, e);
            }

            //d
            if (d + e == 0)
            {
                result = 1;
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
            else if (result == 0)
            {
                Console.WriteLine("no zero subset");
            }
                
        }
        static int? trueInt (string input)
        {
            int number = 0;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }
    }
