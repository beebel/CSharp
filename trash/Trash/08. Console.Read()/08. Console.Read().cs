﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ConsoleRead
    {
        static void Main()  
        {
            //int codeRead = 0;
            //do
            //{
            //    codeRead = Console.Read(); // Console.Read() връща инт код за номера на символа (връща -1 ако няма повече символи), за разлика от Console.Readline() който връща стринг независимо какво сме въвели и трябва да го канвъртваме или парсваме, ако искаме да ползваме инпута като числа
            //    if (codeRead != 0)
            //    {
            //        Console.Write((char)codeRead);
            //    }
            //}
            //while (codeRead != 10);


            ////Тази програма чете един ред от потребителя и го отпечатва символ по символ. Това става възможно благодарение на малка хитринка - предварително знаем, че клавишът Enter всъщност вписва в буфера два символа. Това са "carriage return" код (ASCII 13) следван от "linefeed" код (ASCII 10). За да разберем, че един ред е свършил ние търсим за символ с код 10. По този начин програмата прочита само един ред и излиза от цикъла.
            ////Трябва да споменем, че методът Console.Read() почти не се използва в практиката, при наличието на алтернативата с Console.ReadLine(). Причината за това е, че вероятността да сгрешим с Console.Read() е доста по-голяма отколкото ако изберем алтернативен подход, а кодът най-вероятно ще е ненужно сложен

            //// бачка си и за букви и за числа- ще ни ги печата
            //// друг пример за Console.Read():
            //int i = Console.Read();
            //char ch = (char)i; // cast the int value to char
            //Console.WriteLine("The code of '{0}' is {1}.", ch, i);

            //i = Console.Read(); // ако стринга който сме въвели има два или повече символа, ще отпечата един под друг кодовете на само първите два символа от стринга- останалите ще ги игнорира
            //ch = (char)i;
            //Console.WriteLine("The code of '{0}' is {1}.", ch, i); // но ако е само един, той печата само първия символ, а за втория пише "is 13" 

            //char symbol = (char)13; // ako речем да го видим какво представлява тоя символ с код 13, става ясно, че тва е нов ред (carriage return) 
            //Console.WriteLine(symbol); // печата курсора на нов ред, демек нищо не се вижда, освен че сме един ред по-надолу


            //// чете символ по символ цял ред:

            string text = null;
            while (true)
            {
                int readInt = Console.Read();
                if (readInt == 10)
                {
                    break;
                }
                text += (char)readInt; // ако не е кастнато с (char) ще ни конкатенира номерата на символите в аски, т.е. ще конкатенира интове само
            }
            Console.WriteLine(text);

            Console.WriteLine((char)('b' + 1));  //принти "c", защото в скобите, към номера на b в аски, добавя 1
                                                 // т.е. събира два инта и резултата им го каства с char и дава символа
                                                 // който за него в аски- т.е. "c", което е логично- последователни букви са все пак.
        }
    }