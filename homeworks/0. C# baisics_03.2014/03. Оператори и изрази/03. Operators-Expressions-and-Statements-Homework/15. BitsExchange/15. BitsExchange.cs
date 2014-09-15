// Problem 15.*     Bits Exchange
//
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
// Examples:
//
//  n	        binary   representation of n            binary result	                        result
//  1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
//  255406592	00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
//  4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
//  5351	    00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	    67114183
//  2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Title = "15.* Bits Exchange";
        uint n;
        uint mask;
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Please enter an unsigned integer number (n): ");
                string input = Console.ReadLine();
                if (uint.TryParse(input, out n))    // if (true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine("binary representation of n: {0}", Convert.ToString(n, 2).PadLeft(32, '0')); // uint converted to string in binary system (n, 2) with padleft
            uint nRight;
            nRight = n >> 3;
            uint bit3 = nRight & 1;
            nRight = n >> 4;
            uint bit4 = nRight & 1;
            nRight = n >> 5;
            uint bit5 = nRight & 1;
            nRight = n >> 24;
            uint bit24 = nRight & 1;
            nRight = n >> 25;
            uint bit25 = nRight & 1;
            nRight = n >> 26;
            uint bit26 = nRight & 1;
            if (bit3 != bit24) // if the are equal there is no need of exchange
            {
                if (bit3 == 0) // and bit24 == 1
                {
                    mask = (uint)1 << 3;
                    n = mask | n;
                    mask = ~((uint)1 << 24);
                    n = mask & n;
                }
                else // (bit3 == 1) && (bit24 == 0)
                {
                    mask = ~((uint)1 << 3);
                    n = mask & n;
                    mask = 1 << 24;
                    n = mask | n;
                }
            }
            if (bit4 != bit25) // if the are equal there is no need of exchange
            {
                if (bit4 == 0) // and bit25 == 1
                {
                    mask = (uint)1 << 4;
                    n = mask | n;
                    mask = ~((uint)1 << 25);
                    n = mask & n;
                }
                else // (bit4 == 1) && bit25 == 0
                {
                    mask = ~((uint)1 << 4);
                    n = mask & n;
                    mask = (uint)1 << 25;
                    n = mask | n;
                }
            }
            if (bit5 != bit26) // if the are equal there is no need of exchange
            {
                if (bit5 == 0) // and bit26 == 1
                {
                    mask = (uint)1 << 5;
                    n = mask | n;
                    mask = ~((uint)1 << 26);
                    n = mask & n;
                }
                else // (bit5 == 1) && bit26 == 0
                {
                    mask = ~((uint)1 << 5);
                    n = mask & n;
                    mask = (uint)1 << 26;
                    n = mask | n;
                }
            }
            Console.WriteLine("binary result:              {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("result: {0}\n", n);
        }
    }
}
