// Problem 12.  Extract Bit from Integer
//
// Write an expression that extracts from given integer n the value of given bit at index p. Examples:
//
//  n	    binary representation	p	bit @ p
//------------------------------------------------
//  5	    00000000 00000101	    2	    1
//  0	    00000000 00000000	    9	    0
//  15	    00000000 00001111	    1	    1
//  5343	00010100 11011111	    7	    1
//  62241	11110011 00100001	    11	    0


using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Title = "12. Extract Bit from Integer";
            int num;
            int p;  // position of the bit
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
                Console.WriteLine("binary representation: {0}", Convert.ToString(num, 2).PadLeft(16, '0')); // int converted to string in binary system (num, 2) with padleft
                int mask = num >> p; // bit3 going on position 0
                int bitP = mask & 1; // the bit at a positon P in the original input (num)
                Console.WriteLine("p: {0}",p);
                Console.WriteLine("bit #p: {0}\n", bitP);
            }
        }
    }