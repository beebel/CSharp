// Problem 3.   Divide by 7 and 5
// Write a Boolean expression that checks for given integer 
// if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
//
//   n	    Divided by 7 and 5?
//------------------------------
//   3	    false
//   0	    false
//   5	    false
//   7	    false
//   35	    true
//   140	true


using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Title = "03. Divide by 7 and 5";
            int num;
            bool result;
            for (int i = 0; i < 6; i++) // for six loops i.e. six numbers to check
            {
                while (true)    // to gurantee a corect integer input
                {
                    Console.Write("Please enter the integer number you want to check:   ");
                    string input = Console.ReadLine();
                    bool check = int.TryParse(input, out num);
                    if (check == true)
                    {
                        if ((num >= int.MinValue) && (num <= int.MaxValue)) // a true integer
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
                        Console.WriteLine("Incorrect input!");
                    }
                }
                if (num == 0)
                {
                    result = false;
                }
                else
                {
                    bool dividedBy7 = (num % 7 == 0); // can be divided by 7 whitout remainder?
                    bool dividedBy5 = (num % 5 == 0); // can be divided by 5 whitout remainder?
                    result = dividedBy7 && dividedBy5;// result is true if both dividedBy7 and dividedBy5 are true
                }
                Console.WriteLine("\n{0,6}{1,30}", "n", "Divided by 7 and 5?");
                string line = new String('-', 44);
                Console.WriteLine(line);
                Console.WriteLine("{0,6}{1,30}\n", num, result);
            }
        }
    }
