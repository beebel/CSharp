// Problem 14.  Modify a Bit at Given Position
//
// We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p   
// from the binary representation of n while preserving all other bits in n. Examples:
//
//  n	    binary representation of n	    p	v	binary result	    result
//  5	    00000000 00000101	            2	0	00000000 00000001	1
//  0	    00000000 00000000	            9	1	00000010 00000000	512
//  15	    00000000 00001111	            1	1	00000000 00001111	15
//  5343	00010100 11011111	            7	0	00010100 01011111	5215
//  62241	11110011 00100001	            11	0	11110011 00100001	62241


using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Title = "14. Modify a Bit at Given Position";
        int num;
        int p;  // position of the bit
        int v; // a bit value (v = 0 || v = 1)
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
            while (true)
            {
                Console.Write("Please enter a bit value:    ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out v))    // if (true)
                {
                    if ((v == 0) || (v == 1))   // correct value of a bit
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine("binary representation of n: {0}", Convert.ToString(num, 2).PadLeft(16, '0')); // int converted to string in binary system (num, 2) with padleft
            int mask = 1;
            if (v == 1)
            {
                mask = mask << p; // bitV going on position p // e.g. p = 2, v = 1 ((000... 0001) << 2) // 000... 0100 
                num = num | mask; // e.g. num = 0000... 1010, (0000...0100 | 0000... 1011) // 0000... 1111 ,bit p was modified to the value of v
            }
            else // v = 0
            {
                mask = mask << p;  // e.g. p = 2, (000...0001 << 2) // 000...0100
                mask = ~mask;     // e.g. 111...1011 (the bit at position p has the value of v (0))     
                num = num & mask;      // e.g. num = 000...0101, (111...1011 & 000...0101) // 000...0001
            }
            Console.WriteLine("binary result: {0}", Convert.ToString(num, 2).PadLeft(16, '0')); // the binary representation of result
            Console.WriteLine("result: {0}\n", num);
        }
    }
}

