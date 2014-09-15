// Problem 11.  Bitwise: Extract Bit #3
//
// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
// The bits are counted from right to left, starting from bit #0. 
// The result of the expression should be either 1 or 0. Examples:
//
// n	    binary representation	bit #3
//---------------------------------------------
// 5	    00000000 00000101	    0
// 0	    00000000 00000000	    0
// 15	    00000000 00001111	    1
// 5343	    00010100 11011111	    1
// 62241	11110011 00100001	    0


using System;

    class ExtractBit3
    {
        static void Main()
        {
            Console.Title = "11. Bitwise: Extract Bit #3";
            uint num;
            for (int i = 0; i < 5; i++) 
            {
                while (true)    
                {
                    Console.Write("Please enter an unsigned integer:    ");
                    string input = Console.ReadLine();
                    if (uint.TryParse(input, out num))    // if (true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                Console.WriteLine("binary representation:               {0}", Convert.ToString(num, 2).PadLeft(16, '0')); // uint converted to string in binary system (num, 2) with padleft
                uint mask = num >> 3; // bit3 going on position 0
                uint bit3 = mask & 1;
                Console.WriteLine("bit #3:                              {0}\n", bit3);
            }
        }
    }
