// Problem 3.   The Explorer
//
// Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. Today he is
// going on an expedition to collect all kind of diamonds, no matter small or large. Help your friend to find all
// the diamonds in the biggest known cave "The Console Cave". At the only input line you will be given the
// width of the diamond. The char that forms the outline of the diamonds is '*' and the surrounding parts are
// made of '-' (see the examples). Your task is to print a diamond of given size n.
//
// Input:
// Input data should be read from the console.
//      •	The only input line will hold the width of the diamond – n.
// The input data will always be valid and in the format described. There is no need to check it explicitly.
//
// Output:
// The output data must be printed on the console.
//       •	The output lines should hold the diamond. 
//
// Constraints:
//            •	The number n is positive odd integer between 3 and 59, inclusive.
//            •	Allowed working time for your program: 0.25 seconds.
//            •	Allowed memory: 16 MB.
//
// Examples:
//
//          Input	Output                  Input	Output
//          5       --*--                   7       ---*---
//                  -*-*-                           --*-*--
//                  *---*                           -*---*-
//                  -*-*-                           *-----*
//                  --*--                           -*---*-
//                                                  --*-*--
//                                                  ---*---                                  



using System;


class TheExplorer
{
    static void Main()
    {
        int width = Convert.ToInt32(Console.ReadLine());
        int middle = (width / 2) + 1;
        int star1Pos = middle;
        int star2Pos = middle;
        Console.WriteLine(new string('-', middle - 1) + '*' + new string('-', middle - 1));
        for (int i = 0; i < middle - 1; i++)
        {
            star1Pos--;
            star2Pos++;
            if ((star1Pos >= 0) && (star2Pos <= width));
            {
                string lineTillFirstStar = new string('-', star1Pos - 1);
                string lineTillMiddle = new string('-', middle - (star1Pos + 1));
                string middleLine = "-";
                string lineTillSecondStar = new string('-', Math.Abs(middle - (star2Pos - 1)));
                string lineTillEndLine = new string('-', star1Pos - 1);
                Console.Write(lineTillFirstStar + '*' + lineTillMiddle + middleLine + lineTillSecondStar + '*'
                                                                                         + lineTillEndLine + "\n");
            }
        }
        for (int c = 0; c < middle - 2; c++)
        {
            star1Pos++;
            star2Pos--;
            {
                if ((star1Pos == middle) && (star2Pos == middle));
                {
                    string lineTillFirstStar = new string('-', star1Pos - 1);
                    string lineTillMiddle = new string('-', middle - (star1Pos + 1));
                    string middleLine = "-";
                    string lineTillSecondStar = new string('-', Math.Abs(middle - (star2Pos - 1)));
                    string lineTillEndLine = new string('-', star1Pos - 1);
                    Console.Write(lineTillFirstStar + '*' + lineTillMiddle + middleLine + lineTillSecondStar + '*' 
                                                                                         + lineTillEndLine + "\n");
                }
            }
        }
        Console.WriteLine(new string('-', middle - 1) + '*' + new string('-', middle - 1));
    }
}
