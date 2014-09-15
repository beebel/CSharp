// Problem 2.   Gravitation on the Moon
//
// The gravitational field of the Moon is approximately 17% of that on the Earth. 
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
//
// weight	weight on the Moon
// 86	    14.62
// 74.6	    12.682
// 53.7	    9.129



using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Title = "02. Gravitation on the Moon";
            decimal weight;
            for (int i = 0; i < 3; i++) // for three loops i.e. three checks of weight 
            {
                while (true)    // to gurantee a corect weight input
                {
                    Console.Write("Please enter the weight of the man:  ");
                    string input = Console.ReadLine();
                    //bool check = decimal.TryParse(input, out weight); // this line is not needed actually - we dont need to delcare and initialize a boolean variable
                    if (decimal.TryParse(input, out weight))    // if (true)
                    {
                        if ((weight > 0) && (weight <= 1000)) // Jon Brower Minnoch (USA), was the heaviest man on earth, weighed 635 kg.
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
                decimal result = ((17 * weight)/100); 
                Console.WriteLine("\n{0,15}{1,30}", "weight", "weight on the Moon");
                string line = new String('-', 60);
                Console.WriteLine(line);
                Console.WriteLine("{0,15}{1,30}\n", weight, result);
            }  
        }
    }
