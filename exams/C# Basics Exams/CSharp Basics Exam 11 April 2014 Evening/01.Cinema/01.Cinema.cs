using System;

    class Cinema
    {
        static void Main()
        {
            string typeMovie = Console.ReadLine();
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            int seatsTotal = rows * columns;
            decimal ticketPrice = 0;
            decimal incomes = 0;
            switch (typeMovie)
            {
                case "Premiere": ticketPrice = 12.00M; break;
                case "Normal": ticketPrice = 7.50M; break;
                case "Discount": ticketPrice = 5.00M; break;
            }
            incomes = seatsTotal * ticketPrice;
            Console.WriteLine("{0,00} leva", incomes);
        }
    }
