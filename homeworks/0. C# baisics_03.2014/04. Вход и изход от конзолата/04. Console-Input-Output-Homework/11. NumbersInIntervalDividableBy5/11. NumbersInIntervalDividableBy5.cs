// Problem 11.*     Numbers in Interval Dividable by Given Number
//
// Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0. Examples:

//      start	end	    p	    comments
//      17	    25	    2	    20, 25
//      5	    30	    6	    5, 10, 15, 20, 25, 30
//      3	    33	    6	    5, 10, 15, 20, 25, 30
//      3	    4	    0	    -
//      99	    120	    5	    100, 105, 110, 115, 120
//      107	    196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195


using System;

    class NumbersInIntervalDividableBy5
    {
        static void Main()
        {
            Console.Title = "11. Numbers in Interval Dividable By 5";
            int start, end;
            int p = 0;  // used also as an index of the positions of the array
            for (int i = 0; i < 6; i++) // 6 examples
            {
                while (true)        // correct input for the starting number
                {
                    Console.Write("Please enter a positive integer for the starting number: ");
                    string inputStart = Console.ReadLine();
                    if (int.TryParse(inputStart, out start) && start > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct input.");
                    }
                }
                while (true)        // correct input for the ending number
                {
                    Console.Write("Now please enter a bigger integer for the ending number: ");
                    string inputEnd = Console.ReadLine();
                    if ((int.TryParse(inputEnd, out end) && end > 0) && end > start)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not correct input.");
                    }
                }
                int size = ((end - start) / 5) + 1; // interval of numbers dividable by 5 plus additional 1 (ex.: start = 5, end = 11; (end-start) / 5 = 1 (but not 2 as we want for p: 5, 10)  
                int [] numbers = new int [size];  // array with big enough size to store the numbers, but we are not sure that all of it's positions will be taken by them (because of the additional 1 it's possible the last one position to stay unused and empty i.e. with value 0)   
                for (int c = start; c <= end; c++)
                {
                    if (c % 5 == 0)
                    {
                        numbers[p] = c;     
                        p++;               // at the very end of the loop p is bigger than [p] with 1, which is the correct number of the elements dividable by 5
                    }            
                }
                if (p == 0) // no elements have been added to the array and numbers[index] is empty or have just one 0 in it (unused position given by the size) 
                {
                    Console.WriteLine("\n{0, 9}{1, 7}{2, 5}{3, 12}", "start", "end", "p", "comment");
                    Console.Write("{0, 6}{1, 9}{2, 6}{3, 6}", start, end, p, "-");
                    Console.WriteLine("\n");
                }
                else
                { 
                    Console.WriteLine("\n{0, 9}{1, 7}{2, 5}{3, 12}", "start", "end", "p", "comment");
                    string marginRight = new string(' ', 5);
                    Console.Write("{0, 6}{1, 9}{2, 6}{3}", start, end, p, marginRight);
                    for (int count = 0; count < (p - 1); count++) // printing elements of the array with the exception of the last one number numbers[p-1] (which stores any value different than 0)
                    {
                        Console.Write("{0}, ", numbers[count]);
                    }
                    Console.Write("{0}", numbers[p - 1]);     // printing the last element of the array
                    Console.WriteLine("\n");
                    p = 0;                            // for the next example  
                } 
            }
        }
    }
