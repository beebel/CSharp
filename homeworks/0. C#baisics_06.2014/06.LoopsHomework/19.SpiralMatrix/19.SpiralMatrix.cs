// Problem 19.**  Spiral Matrix

// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
// and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
// Examples:

//        n	 matrix		n	matrix		n	matrix
//        2	 1 2        3	1 2 3       4	1  2  3  4
//           4 3		    8 9 4           12 13 14 5
//                          7 6 5           11 16 15 6
//                                          10 9  8  7






using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Title = "19.** Spiral Matrix";

        int num;
        int row = 0;
        int col = 0;
        int number = 1;

        for (int t = 1; t <= 3; t++)        // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                Console.Write("Enter an integer number for n:  ");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out num);

                if ((checkInput) && (num >= 1) && (num <= 20))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input for n!\n");
                }
            }

            int[,] spiralMatrix = new int[num, num];

            for (int i = 1; i <= spiralMatrix.Length; i++)
            {
                while (true)
                {
                    spiralMatrix[row, col] = number;
                    if (col + 1 < num && spiralMatrix[row, col + 1] == 0)  // the free positions of the elements in array
                    {                                                      // are evaluated to deffault value
                        col++;
                        number++;
                    }
                    else break;
                }
                while (true)
                {
                    spiralMatrix[row, col] = number;
                    if (row + 1 < num && spiralMatrix[row + 1, col] == 0)
                    {
                        row++;
                        number++;
                    }
                    else break;
                }
                while (true)
                {
                    spiralMatrix[row, col] = number;
                    if (col - 1 >= 0 && spiralMatrix[row, col - 1] == 0)
                    {
                        col--;
                        number++;
                    }
                    else break;
                }
                while (true)
                {
                    spiralMatrix[row, col] = number;
                    if (row - 1 >= 0 && spiralMatrix[row - 1, col] == 0)
                    {
                        row--;
                        number++;
                    }
                    else break;
                }
            }

            Console.WriteLine("\n\n");


            for (int printRow = 0; printRow < num; printRow++)
            {
                for (int printCol = 0; printCol < num; printCol++)
                {
                    Console.Write("{0,-3} ", spiralMatrix[printRow, printCol]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");

            row = 0;
            col = 0;
            number = 1;

        }
    }
}


