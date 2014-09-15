// Problem 09.      Play with Int Double and String
//
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one. If the variable is a string, 
//  the program appends "*" at the end. Print the result at the console. Use switch statement. Example:

    //         program	        user		            program	         user
    // Please choose a type:                    Please choose a type:       
    // 1 --> int                                1 --> int                  
    // 2 --> double             3               2 --> double             2   
    // 3 --> string	                            3 --> string             	
    // Please enter a string:	hello		    Please enter a double:	 1.5
    // hello*			                        2.5	


using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Title = "09. Play with Int Double and String";
            object result = null;
            for (int i = 0; i < 3; i++)   // for 3 examples
            {
                while (true)
                {
                    Console.WriteLine("1 --> int");
                    Console.WriteLine("2 --> double");
                    Console.WriteLine("3 --> string");
                    Console.Write("Please choose a type: ");
                    int? choice = correctIntInput(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            while (true)
                            {
                                Console.Write("Please enter an int number: ");
                                int? inputInt = correctIntInput(Console.ReadLine());
                                if (inputInt != null)
                                {
                                    int resultInt = 0;
                                    resultInt = inputInt.GetValueOrDefault();
                                    resultInt = resultInt + 1;
                                    result = resultInt;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid type, the input is not an int number.");
                                }
                            }
                            break;
                        case 2:
                            while (true)
                            {
                                Console.Write("Please enter a double number: ");
                                double? inputDouble = correctDoubleInput(Console.ReadLine());
                                if (inputDouble != null)
                                {
                                    double resultDouble = 0d;
                                    resultDouble = inputDouble.GetValueOrDefault();
                                    resultDouble = resultDouble + 1;
                                    result = resultDouble;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid type, the input is not a double number.");
                                }
                            }
                            break;
                        case 3:
                            Console.Write("Please enter a string: ");
                            string inputString = Console.ReadLine();
                            inputString = inputString + "*";
                            result = inputString;
                            break;
                        case null:
                            Console.WriteLine("\nInvalid choice, the input is not an integer number.\n"); // изобщо не е инт.
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice, the input is not in the range [1..3].\n"); // инт е, но е извън [1..3]
                            break;
                    }
                    if (result != null)   // т.е. имаме някакъв резултат
                    {
                        Console.WriteLine("\nresult: {0}", result);
                        Console.WriteLine();
                        result = null;      // за следващото завъртане на лупа
                        break;
                    }
                }
            }
        }
        static int? correctIntInput(string input)
        {
            int digit1To3 = 0;
            if (int.TryParse(input, out digit1To3))
            {
                return digit1To3;
            }
            else
            {
                return null;
            }
        }
        static double? correctDoubleInput(string input)
        {
            double realNumber = 0;
            if (double.TryParse(input, out realNumber))
            {
                return realNumber;
            }
            else
            {
                return null;
            }
        }
    }
