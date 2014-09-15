using System;

    class StringToInt
    {
        static void Main()
        {
            var test = Console.ReadLine();      // квото и да въведем тук
            Console.WriteLine(test.GetType()); // ще е от тип стринг
            Console.WriteLine(Convert.ToInt32(test)); // всъщност това пак е стринг
            Console.WriteLine(int.Parse(test)); // може и така да се изпише
            Console.WriteLine(test.GetType());   // ето, стринг си е
            var test2 = Convert.ToInt32(test);  //  но така вече ще стане на инт
            Console.WriteLine(test2.GetType()); // int си е 
            // основна разлика между двата метода за парсване:
            Console.WriteLine(Convert.ToInt32(null)); // тва работи някак с аномалията, че връща за int, че 0
            Console.WriteLine(int.Parse(null)); // тва обаче гърми
        }
    }

