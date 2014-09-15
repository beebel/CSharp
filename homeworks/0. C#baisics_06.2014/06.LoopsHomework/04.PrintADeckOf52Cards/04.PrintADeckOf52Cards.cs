// Problem 4.	Print a Deck of 52 Cards

// Write a program that generates and prints all possible cards from a standard deck 
// of 52 cards (without the jokers). The cards should be printed using 
// the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
// Use 2 nested for-loops and a switch-case statement.

//          output
//          2♣ 2♦ 2♥ 2♠
//          3♣ 3♦ 3♥ 3♠
//          …
//          K♣ K♦ K♥ K♠
//          A♣ A♦ A♥ A♠


using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.Title = "04. Print a Deck of 52 Cards";

        string card = null;
        string colour = null;

        for (int i = 2; i <= 14; i++)
        {
            switch(i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    card = i.ToString();
                    break;
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default:
                    Console.WriteLine("Error \"card\"!");
                    break;
            }

            for (int c = 0; c < 4; c++)
            {
                switch(c)
                {
                    case 0:
                        colour = "♣";
                        break;   
                    case 1:      
                        colour = "♦";
                        break;   
                    case 2:      
                        colour = "♥";
                        break;   
                    case 3:      
                        colour = "♠";
                        break;
                    default:
                        Console.WriteLine("Error\"colour\"!");
                        break;
                }

                Console.Write("{0}{1} ", card, colour);              
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
