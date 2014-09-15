// 04. Five Special Letters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class FiveSpecialLetters
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Dictionary<char, int> weights = new Dictionary<char, int>() 
            { { 'a', 5 }, { 'b', -12 }, { 'c', 47 }, { 'd', 7 }, { 'e', -32 } };

            bool isAnyMagicNum = false;

            for (char ch1 = 'a'; ch1 <= 'e'; ch1++)
            {
                for (char ch2 = 'a'; ch2 <= 'e'; ch2++)
                {
                    for (char ch3 = 'a'; ch3 <= 'e'; ch3++)
                    {
                        for (char ch4 = 'a'; ch4 <= 'e'; ch4++)
                        {
                            for (char ch5 = 'a'; ch5 <= 'e'; ch5++)
                            {
                                string currentWord = "" + ch1 + ch2 + ch3 + ch4 + ch5;

                                string currentWordWithUniqueChars = "";

                                for (int i = 0; i < 5; i++)
                                {
                                    if (IsRepeating(currentWordWithUniqueChars, currentWord[i]))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        currentWordWithUniqueChars += currentWord[i];
                                    }
                                }

                                bool check1 = CalculateWeight(currentWordWithUniqueChars, weights) >= start;
                                bool check2 = CalculateWeight(currentWordWithUniqueChars, weights) <= end;

                                if ((check1) && (check2))

                                {
                                    Console.Write("{0} ", currentWord);
                                    isAnyMagicNum = true;
                                }

                                currentWord = "";
                                currentWordWithUniqueChars = "";

                            }
                        }
                    }
                }
            }

            if (isAnyMagicNum != true)
            {
                Console.Write("No");
            }

            Console.WriteLine();
        }

        static bool IsRepeating (string currentWordNoRepeatingCh, char nextCh)
        {
            bool result = false;
            foreach (var ch in currentWordNoRepeatingCh)
            {
                if (ch == nextCh)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        static int CalculateWeight (string currentWordNoRepeatingCh, Dictionary<char, int> weights)
        {
            int sumWeights = 0;
            int posCh = 1;

            foreach (var ch in currentWordNoRepeatingCh)
            {
                sumWeights += posCh * weights[ch];
                posCh++;
            }
            return sumWeights;        
        }
    }
