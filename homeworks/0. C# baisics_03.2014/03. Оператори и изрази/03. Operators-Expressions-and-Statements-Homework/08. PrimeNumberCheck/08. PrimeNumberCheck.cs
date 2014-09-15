
// Problem 8.   Prime Number Check
//
// Write an expression that checks if given positive integer number n (n ≤ 100) is prime
// (i.e. it is divisible without remainder only to itself and 1). Examples:
//
// n	Prime?
//-----------------
// 1	false
// 2	true
// 3	true
// 4	false
// 9	false
// 97	true
// 51	false
// -3	false
// 0	false

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Title = "08. Prime Number Check";
        int num;
        for (int i = 0; i < 9; i++) // for nine loops i.e. nine checks of integer numbers 
        {
            while (true)    // to gurantee the corect input of int
            {
                Console.Write("Please enter a positive integer number, not bigger than 100:     ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out num))    // if (true)
                {
                    if ((num >= 0) && (num <= 100)) // a positive integer number, not bigger than 100
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            bool prime = false;
            if (num != 1) // else num = 1 and prime = false
            {
                for (int n = 2; n <= num; n++) // from n=2 because (num % 1 == 0) is always true // all int numbers from 2 to num (2 <= n <= 100)
                {
                    if (num % n == 0) // if true  // e.g. (4 % 2 == 0)
                    {
                        if (n == num) // num is prime only when (num % n == 0) is true and n = num // e.g 2 != 4, i.e. 4 is not a prime number
                        {
                            prime = true;
                            break;
                        }
                        else
                        {
                            break;  // and prime = false
                        }
                    }
                }
            }
            Console.WriteLine("\n{0,10}{1,20}", "n", "Prime?");
            string line = new String('-', 30);
            Console.WriteLine("     " + line);
            Console.WriteLine("{0,10}{1,20}\n", num, prime);
        }
    }
}
