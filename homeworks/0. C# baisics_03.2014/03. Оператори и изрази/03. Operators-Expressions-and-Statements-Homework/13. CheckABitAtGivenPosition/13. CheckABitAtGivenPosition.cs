// Problem 13.  Check a Bit at Given Position
//
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
// in given integer number n has value of 1. Examples:
//
//  n	    binary representation of n	    p	    bit @ p == 1
//------------------------------------------------------------------
//  5	    00000000 00000101	            2	    true
//  0	    00000000 00000000	            9	    false
//  15	    00000000 00001111	            1	    true
//  5343	00010100 11011111	            7	    true
//  62241	11110011 00100001	            11	    false

using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Title = "13. Check a Bit at Given Position";
            int num;
            int p;  // position of the searched bit
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Please enter an integer number:  ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out num))    // if (true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (true)
                {
                    Console.Write("Please enter a number (p) for the position of the searched bit:  ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out p))    // if (true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                int mask = num >> p; // bitP going on position 0
                int bitP = mask & 1; // the bit at a positon P in the original input (num)
                Console.WriteLine("binary representation: {0}", Convert.ToString(num, 2).PadLeft(16, '0')); // int converted to string in binary system (num, 2) with padleft
                Console.WriteLine("p: {0}", p);
                Console.WriteLine("bit #p == 1: {0}\n", ((bitP == 1) ? "true" : "false"));
            }
        }
    }

