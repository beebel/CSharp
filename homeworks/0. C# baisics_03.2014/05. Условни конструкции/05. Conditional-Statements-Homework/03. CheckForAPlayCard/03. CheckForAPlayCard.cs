// Problem 03.      Check for a Play Card
//
// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K 
// and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
// Examples:
//
//  character	Valid card sign?
//  5	        yes
//  1	        no
//  Q	        yes
//  q	        no
//  P	        no
//  10	        yes
//  500	        no


using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Title = "03. Check for a Play Card";
            string result;
            for (int i = 0; i < 7; i++)         // 7 examples
            {
                Console.Write("Enter the sign of the card: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        result = "yes";
                        break;
                    default:        // проверяваме и за числата- ако са в [2..10] резултатът е "yes", иначе е "no"
                        int? number = parseNullableInt(input);
                        if (number != null)
                        {
                            result = "yes";
                        }
                        else
                        {
                            result = "no";
                        }
                        break;
                }
                Console.WriteLine("\n{0,15}{1,22}", "character", "Valid card sign?");
                string line = new string('_', 35);
                Console.WriteLine("   " + line);
                Console.WriteLine("{0,7}{1,17}", input, result);
                Console.WriteLine();
            }
        }
        static int? parseNullableInt(string input)
        {
            int parseInt = 0;
            if (int.TryParse(input, out parseInt) && (parseInt >= 2) && (parseInt <= 10))
            {
                return parseInt;
            }
            else
            {
                return null;
            }
        }
    }
