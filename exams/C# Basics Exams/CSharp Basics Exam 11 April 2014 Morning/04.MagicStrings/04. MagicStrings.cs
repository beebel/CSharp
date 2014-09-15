// Problem 4.   MagicStrings
//
// You are given a number diff. Write a program to generate all sequences of 8 letters, each from the set 
// { 'd', 'b', 'a', 'c' }, such that the weight of the first 4 letters differs from the weight of the second
//  4 letters exactly by diff. These sequences are called “magic strings”. Print them in alphabetical order.
//
// The weight of a single letter is calculated as follows:  weight('d') = 3; weight('b') = 4;  weight('a') = 1;
// weight('c') = 5. The weight of a sequence of 4 letters is the calculated as sum of the weights of these
// 4 individual letters.
//
// Input:
//      •	The input data should be read from the console.
//      •	The number diff stays at the first line.
// The input data will always be valid and in the format described. There is no need to check it explicitly.
//
// Output:
// The output should be printed on the console as a sequence of strings in alphabetical order. Each string should
// stay on a separate line. In case no magic strings exist, print “No”.
//
// Constraints:
//            •	The number diff will be an integer number in the range [0…100].
//            •	Allowed working time for your program: 0.25 seconds.
//            •	Allowed memory: 16 MB.
//
// Examples:
//          Input	Output	            Comments
//          16      kkkkpppp        weight('kkkk') = 4; weight('pppp') = 20; diff = 16
//                  ppppkkkk        weight('pppp') = 4; weight('kkkk') = 20; diff = 16
//
//          Input	Output	            Comments
//          15      kkkknppp        weight('kkkk') = 4; weight('nppp') = 19; diff = 15
//                  kkkkpnpp        weight('kkkk') = 4; weight('pnpp') = 19; diff = 15
//                  kkkkppnp        weight('kkkk') = 4; weight('ppnp') = 19; diff = 15
//                  kkkkpppn        weight('kkkk') = 4; weight('pppn') = 19; diff = 15
//                  npppkkkk        weight('nppp') = 19; weight('kkkk') = 4; diff = 15
//                  pnppkkkk        weight('pnpp') = 19; weight('kkkk') = 4; diff = 15
//                  ppnpkkkk        weight('ppnp') = 19; weight('kkkk') = 4; diff = 15
//                  pppnkkkk        weight('pppn') = 19; weight('kkkk') = 4; diff = 15
//
//          Input	Output	            Comments
//          20      No              No magic strings match the specified difference diff

using System;
using System.Collections.Generic;


class MagicStrings
{
    static void Main()
    {
        int diff = Convert.ToInt32(Console.ReadLine());

        List<int> first4Num = new List<int>();
        List<int> second4Num = new List<int>();
        List<string> first4Letter = new List<string>();
        List<string> second4Letter = new List<string>();
             
        for (int i = 4; i <= 20; i++)
        {
            for (int j = 4; j <= 20; j++)
            {
                if ((Math.Abs(i - j) == diff) && (i != 5) && (j != 5))
                {
                    for (int a = 1; a <= 5; a++)
                    {
                        if (a != 2)
                        {
                            for (int b = 1; b <= 5; b++)
                            {
                                if (b != 2)
                                {
                                    for (int c = 1; c <= 5; c++)
                                    {
                                        if (c != 2)
                                        {
                                            for (int d = 1; d <= 5; d++)
                                            {
                                                if (d != 2)
                                                {
                                                    if (a + b + c + d == i)
                                                    { 
                                                        first4Num.Add(a);
                                                        first4Num.Add(b);
                                                        first4Num.Add(c);
                                                        first4Num.Add(d);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for (int e = 1; e <= 5; e++)
                    {
                        if (e != 2)
                        {
                            for (int f = 1; f <= 5; f++)
                            {
                                if (f != 2)
                                {
                                    for (int g = 1; g <= 5; g++)
                                    {
                                        if (g != 2)
                                        {
                                            for (int h = 1; h <= 5; h++)
                                            {
                                                if (h != 2)
                                                {
                                                    if (e + f + g + h == j)
                                                    {     
                                                        second4Num.Add(e);
                                                        second4Num.Add(f);
                                                        second4Num.Add(g);
                                                        second4Num.Add(h);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if ((first4Num.Count > 0) && (second4Num.Count > 0))
        {
            foreach (int num in first4Num)
            {
                first4Letter.Add(convertDigToLetter(num));
            }
            //foreach (int num in second4Num)
            //{
            //    second4Letter.Add(convertDigToLetter(num));
            //}
            //foreach (int e in first4Num)
            //{
            //    Console.Write(e);
            //}
            //Console.WriteLine();
            foreach (int e in second4Num)
            {
                Console.Write(e);
            }
            for (int index = 0; index <= first4Letter.Count; index += 4)
            {

                Console.Write(first4Letter[index], first4Letter[index + 1], first4Letter[index + 2], first4Letter[index + 3],
                             second4Letter[index], second4Letter[index + 1], second4Letter[index + 2], second4Letter[index + 3] + "\n");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
        
    }
    private static string convertDigToLetter (int num)
    {
        if (num == 1)
        {
            return "k";
        }
        if (num == 4)
        {
            return "n";
        }
        if (num == 5)
        {
            return "p";
        }
        if (num == 3)
        {
            return "s";
        }
        else
            return "kur!";
    }
}
