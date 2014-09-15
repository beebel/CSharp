// Problem 12.*  Randomize the Numbers 1…N

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:

//      n	    randomized numbers 1…n
//      3	    2 1 3
//      10	    3 4 8 2 6 7 9 1 10 5 


using System;
using System.Collections.Generic;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Title = "12.* Randomize the Numbers 1...N";

        int n;
        int dice = 0;
        Random rnd = new Random();
        List<int> printNum = new List<int>();


        for (int t = 1; t <= 2; t++)         // for 2 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter a positive integer number for n:  ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out n);

                if ((check) && (n > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for n!\n");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    dice = rnd.Next(From1ToN(n)[0], (From1ToN(n)[n - 1]) + 1);

                    if (isInList(printNum, dice) == -1)
                    {
                        printNum.Add(dice);
                        break;
                    }           
                }               
            }

            foreach (var item in printNum)
            {
                Console.Write("{0} ", item);
            }
            
            Console.WriteLine("\n\n\n");

            printNum.Clear();
        }
    }

    static int[] From1ToN(int num)
    {
        int[] numbers = new int[num];
        int number = 1;

        for (int i = 0; i < num; i++)
        {
            numbers[i] = number;
            number++;
        }

        return numbers;
    }

    static int isInList (List<int> numbers, int num)
    {
        int result = -1;
        foreach (var item in numbers)
        {
            if (item == num)
            {
                result = 1;
                break;
            }
        }
        return result;
    }
}
