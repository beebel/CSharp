using System;

    class IntToString
    {
        static void Main()
        {
            Console.Title = "Int to String";
            int num = 245;
            Console.WriteLine(num);
            string intToString = num.ToString(); // правим го на стринг
            Console.WriteLine(intToString + 9);  // съединяваме го с друго число, но тъй като съединяваме стринг с число, "+" се чете като оператор за конкатенация, а "9" се подразбира също като стринг.
            Console.WriteLine(num); // но всъщност няма никаква промяна при num
            Console.WriteLine(Convert.ToString(6).PadLeft(32,'0'));
            Console.WriteLine(Convert.ToString(~1, 2).PadLeft(32, '0'));// побитово, представено в бинарен вид
            
            // стринг с бинарен запис, го обръщаме в десетична бройна с-ма: 
            Console.Write(Convert.ToInt32("101", 2));
            Console.WriteLine("\n");
        }
    }

