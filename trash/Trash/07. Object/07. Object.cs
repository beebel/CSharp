using System;

    class Object
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // тва е за цветовете, няма общо с обджект
            object number = 123;
            Console.WriteLine(number);
            int test = Convert.ToInt32(number); // канвъртваме обджект-a в инт и го даваме за стойност на test
            Console.WriteLine(test is object);  // object-a е бащата на всички класове, т.е. той винаги е и int
            Console.WriteLine(test is int); 
        }
    }
