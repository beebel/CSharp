
// Problem 5.   Is Third Digit 7
//
// Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
// 
// n	Third digit 7?
//----------------------
// 5	    false
// 701	    true
// 9703	    true
// 877	    false
// 777877	false
// 9999799	true


using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.Title = "05. Is Third Digit 7?";
        int num;
        for (int i = 0; i < 6; i++) // for six loops i.e. six numbers to check
        {
            while (true)    // to gurantee a corect integer input
            {
                Console.Write("Please enter the integer number, which third digit you want to check:    ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out num);
                if (check == true)
                {
                    if ((num >= int.MinValue) && (num <= int.MaxValue)) // a real integer
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            int thirdDigitIsLast = num / 100; // integer division by 100- getting rid of the last two digits of num// ex -12745/100 = -127
            int absThirdDigit = Math.Abs(thirdDigitIsLast % 10); // Math.Abs(-127 % 10) = 7
            bool result = (absThirdDigit == 7);
            Console.WriteLine("\n{0,5}{1,25}", 'n', "Third digit 7?");
            string line = new String('-',35);
            Console.WriteLine(line);
            Console.WriteLine("{0,5}{1,25}\n", num, result);
         }
    }
}