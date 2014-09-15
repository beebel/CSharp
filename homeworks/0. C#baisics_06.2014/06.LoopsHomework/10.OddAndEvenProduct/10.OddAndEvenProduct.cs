// Problem 10.	Odd and Even Product

// You are given n integers (given in a single line, separated by a space). Write a program that checks whether the
// product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the 
// first element is odd, the second is even, etc. Examples:

//        numbers	      result
//        2 1 1 6 3	      yes
//                        product = 6
//        3 10 4 6 5 1	  yes
//                        product = 60
//        4 3 2 5 2	      no
//                        odd_product = 16
//                        even_product = 15



using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Title = "10. Odd and Even Product";

        string input = null;
        int even_product = 1;
        int odd_product = 1;
        int num;
        int index = 1;
        bool result = true;

        for (int t = 1; t <= 3; t++)             // for 3 tests
        {
            Console.WriteLine("test{0}:\n", t);

            while (true)
            {
                input = Console.ReadLine();
                string[] text = input.Split(' ');

                foreach (string ch in text)
                {
                    bool check = int.TryParse(ch, out num);
                    if (check)
                    {
                        if (index % 2 == 1)         // odd
                        {
                            odd_product *= num;
                        }
                        else                        // even
                        {
                            even_product *= num;
                        }

                        index++;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    if (odd_product == even_product)
                    {
                        Console.WriteLine("\nyes\nproduct = {0}\n", odd_product);
                    }
                    else
                    {
                        Console.WriteLine("\nno\nodd_product = {0}\neven_product = {1}\n", odd_product, even_product);
                    }

                    even_product = 1;
                    odd_product = 1;
                    index = 1;
                    result = true;

                    break;
                }
                else      // result == false
                {
                    Console.WriteLine("\nInvalid input!");

                    even_product = 1;
                    odd_product = 1;
                    index = 1;
                    result = true;
                }
                Console.WriteLine();       
            }
            Console.WriteLine("\n\n\n");
        }
        Console.WriteLine();
    }
}
