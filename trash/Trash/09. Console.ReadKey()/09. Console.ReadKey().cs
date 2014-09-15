// Методът Console.ReadKey() изчаква натискане на клавиш на конзолата и
// прочита неговият символен еквивалент, без да е необходимо да се
// натиска [Enter]. Резултатът от извикването на ReadKey() е информация за
// натиснатия клавиш (или по-точно клавишна комбинация), във вид на
// обект от тип ConsoleKeyInfo. Полученият обект съдържа символа, който
// се въвежда чрез натиснатата комбинация от клавиши (свойство KeyChar),
// заедно с информация за клавишите [Shift], [Ctrl] и [Alt] (свойство
// Modifiers). Например, ако натиснем [Shift+A], ще прочетем главна буква
// 'А', а в свойството Modifiers ще присъства флага Shift. Следва пример:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ConsoleReadKey
    {
        static void Main()
        {
            Console.Title = "09. Console.ReadKey()";
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);
        }
    }