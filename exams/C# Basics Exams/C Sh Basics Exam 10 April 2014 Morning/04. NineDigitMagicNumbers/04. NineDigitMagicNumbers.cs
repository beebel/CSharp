// Problem 4.**     Nine-Digit Magic Numbers
// This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: 
// http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
//
// Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of 
// digits, as well as to split them into triples with special properties. Help her to calculate very special numbers 
// called “nine-digit magic numbers”.
//
// You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format 
// abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their
// sum of digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic
// numbers”. Your task is to write a program to print these numbers in increasing order.
//
//  Input:
//        •	The input data should be read from the console.
//        •	The number sum stays at the first line.
//        •	The number diff stays at the second line.
// The input data will always be valid and in the format described. There is no need to check it explicitly.
//
// Output:
// The output should be printed on the console. Print all nine-digit magic numbers matching given difference diff and       
// given sum of digits sum, in increasing order, each at a separate line. In case no nine-digit magic numbers exits,
// print “No”.
//
// Constraints:
//             •	The number sum will be a positive integer number in the range [0…100].
//             •	The number diff will be a positive integer number in the range [0…1000].
//             •	Allowed working time for your program: 0.25 seconds.
//             •	Allowed memory: 16 MB.
//
// Examples:
//
//          Input	  Output	                    Comments   
//          27        125171217        1+2+5+1+7+1+2+1+7 = 27; 171-125 = 46; 217-171 = 46 
//          46        131177223        1+3+1+1+7+7+2+2+3 = 27; 177-131 = 46; 223-177 = 46 
//                    221267313        2+2+1+2+6+7+3+1+3 = 27; 267-221 = 46; 313-267 = 46
//
//          Input	  Output	                    Comments   
//          24        121224327        1+2+1+2+2+4+3+2+7 = 24; 224-121 = 103; 327-224 = 103
//          103       211314417        2+1+1+3+1+4+4+1+7 = 24; 314-211 = 103; 417-314 = 103 
//
//          Input	  Output	                    Comments   
//          12        No               No nine-digit magic numbers with sum=12 and diff=15
//          15


 
using System;
using System.Collections.Generic;

    class NineDigitMagicNumbers
    {
        static void Main()
        {
            List<int> noZero3DigitNum = new List<int>();   // all 3 digited num from 111 to 777, excluding num with digit 0, 8 and 9 in them   
            List<int> abcDefGhi = new List<int>();          // all 3 digited num from noZero3DigitNum matching requirements: def - abc = dif; ghi - def = dif
            List<int> result = new List<int>();             // collecting every 3 num (abc, def, ghi) from abcDefGhi() as 9 digits
            int digitAtPos3 = 0;        // for the last digits of numbers abc, def and ghi (c, f, i)
            int digitAtPos2 = 0;        // for the second digits (b, e, h)      
            int digitAtPos1 = 0;        // first digits in numbers, at positions a, d, g 
            int sumAbcDefGhi = 0;       // sum of digits in list abcDefGhi
            bool notMagicNum = true;    // засега нямаме резултат

            int sum = Convert.ToInt32(Console.ReadLine());
            int diff = Convert.ToInt32(Console.ReadLine());

            for (int i = 111; i <= 777; i++)                    // всички трицифрени числа без 0,8 и 9 от 111 до 777
            {
                if ((i % 10 != 0) && (i % 10 != 8) && (i % 10 != 9) && ((i / 10) % 10 != 0) && ((i / 10) % 10 != 8) && ((i / 10) % 10 != 9))
                {
                    noZero3DigitNum.Add(i);                     // ги cъбираме в лист
                }
            }

            for (int abc = 0; abc < noZero3DigitNum.Count; abc++)     // обхождаме листа, като за всяко едно негово число
            {
                for (int def = abc + 1; def < noZero3DigitNum.Count; def++)   //проверяваме, дали извадено от следващите го,   
                {
                    if (noZero3DigitNum[def] - noZero3DigitNum[abc] == diff) // дава разлика diff  // if true- list[abc] e abc число, а list[def] e def число, такива, че def - abc = diff
                    {
                        for (int ghi = def + 1; ghi < noZero3DigitNum.Count; ghi++) // за всяка намерена двойка abc и def, проверяваме следващите def числа в списъка, дали някое от тях ако извади def от себе си, ще даде разлика diff
                        {
                            if (noZero3DigitNum[ghi] - noZero3DigitNum[def] == diff) // if true ghi - def = diff
                            {
                                abcDefGhi.Add(noZero3DigitNum[abc]);     // abc
                                abcDefGhi.Add(noZero3DigitNum[def]);     // def, такова, че def - abc = diff
                                abcDefGhi.Add(noZero3DigitNum[ghi]);     // ghi, такова, че ghi - def = diff 
                            }
                        }
                    }
                }
            }
            if (abcDefGhi.Count == 0)     // празен лист                   
            {
                Console.WriteLine("No");
            }
            else                                            // имаме последователност от такива числа abc, def и ghi
            {
                for (int c = 0; c < abcDefGhi.Count; c++)
                {
                    digitAtPos3 = abcDefGhi[c] % 10;            // (c, f, i) digits
                    digitAtPos2 = (abcDefGhi[c] / 10) % 10;     // (b, e, h) 
                    digitAtPos1 = abcDefGhi[c] / 100;           // (a, d, g)
                    sumAbcDefGhi = sumAbcDefGhi + digitAtPos1 + digitAtPos2 + digitAtPos3;  // сборът на цифрите
                    result.Add(digitAtPos1);
                    result.Add(digitAtPos2);
                    result.Add(digitAtPos3);
                    if (result.Count == 9)   // 9 цифри, имаме число abcdefghi
                    {
                        if (sumAbcDefGhi == sum)  // проверяваме сумата на 9-те дали е = на sum, if (true) - печатаме
                        {
                            foreach (int digit in result)
                            {
                                Console.Write(digit);
                                notMagicNum = false;  //  имаме резултат, принтирали сме го
                            }
                            Console.WriteLine();  // за да отпечатаме следващото число на нов ред
                        }
                        sumAbcDefGhi = 0;
                        result.Clear();      // приключили сме с това число, чистим си листа и сумата на цифрите му, за следващите числа, които трябва да се проверят
                    }
                }
                if (notMagicNum)
                {
                    Console.WriteLine("No");    // сборът на цифрите на нито една група abc, def и ghi числa не е равен на sum
                }
            }
        }
    }
