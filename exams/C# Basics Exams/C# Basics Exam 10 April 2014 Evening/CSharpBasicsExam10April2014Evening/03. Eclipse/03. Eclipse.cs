// Problem 3**  Eclipse
//
// Write a program to print a figure at the console in the form of sunglasses for watching the solar eclipse.
//
// Input:
//      •	The input data should be read from the console.
//      •	You have an integer number N (always an odd number) specifying the height of sunglasses.
// The input data will always be valid and in the format described. There is no need to check it explicitly.
//
// Output:
// The output should be printed on the console.
// You should print the sunglasses on the console. The sunglasses consist of three parts: frames, lenses and a 
// bridge (the connection between the two frames). Each frame's width is double the height N and should be 
// printed using the character '*' (asterisk) without the corners which should be printed with ' ' (space). Print
// the lenses with the character '/'. Finally, connect the two frames with a bridge that is of size N-1, using the
// character '-'. Leave the rest of the space between the frames blank.
//
// Constraints:
//            •	The number N will be a positive odd integer number in range [3…101].
//            •	Allowed working time for your program: 0.25 seconds.
//            •	Allowed memory: 16 MB.
//
// Examples:
//
//          Input	Output                          Input	Output
//          3        ****    ****                   7        ************        ************
//                  *////*--*////*                          *////////////*      *////////////*
//                   ****    ****                           *////////////*      *////////////*
//                                                          *////////////*------*////////////*
//                                                          *////////////*      *////////////*
//                                                          *////////////*      *////////////*
//                                                           ************        ************ 



using System;

    class Eclipse
    {
        static void Main()
        {
            int height, width, bridge, middleHeight;
            height = int.Parse(Console.ReadLine());
            width = height * 2;
            bridge = height - 1;
            middleHeight = (height / 2) + 1;            // bridge line

            Console.Write(" ");                         // top frame
            Console.Write(new string('*', width - 2));
            Console.Write(" ");
            Console.Write(new string(' ', bridge));
            Console.Write(" ");
            Console.Write(new string('*', width - 2));
            Console.Write(" ");  
            Console.Write("\n");

            for (int i = 2; i < middleHeight; i++)      // first half lenses
            {
                Console.Write('*');
                Console.Write(new string('/', width - 2));
                Console.Write('*');
                Console.Write(new string(' ', bridge));
                Console.Write('*');
                Console.Write(new string('/', width - 2));
                Console.Write('*');
                Console.Write("\n");
            }

            Console.Write('*');                             // bridge
            Console.Write(new string('/', width - 2));
            Console.Write('*');
            Console.Write(new string('-', bridge));
            Console.Write('*');
            Console.Write(new string('/', width - 2));
            Console.Write('*');
            Console.Write("\n");

            for (int n = middleHeight + 1; n < height; n++)  // second half lenses
            {
                Console.Write('*');
                Console.Write(new string('/', width - 2));
                Console.Write('*');
                Console.Write(new string(' ', bridge));
                Console.Write('*');
                Console.Write(new string('/', width - 2));
                Console.Write('*');
                Console.Write("\n");
            }

            Console.Write(" ");                             // botton frame
            Console.Write(new string('*', width - 2));
            Console.Write(" ");
            Console.Write(new string(' ', bridge));
            Console.Write(" ");
            Console.Write(new string('*', width - 2));
            Console.Write(" ");
            Console.Write("\n");
        }
    }
