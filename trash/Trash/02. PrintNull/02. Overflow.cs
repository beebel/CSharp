using System;

class Overflow
{
    static void Main()
    {
        Console.Title = "Overflow";
        double d = 5e9d; // 5 * 10^9 
        Console.WriteLine(d); // 5000000000
        int i = (int)d;
        Console.WriteLine(i); // вместо 5е9 печата int.MinValue
        //int i = checked((int)d); // System.OverflowException- checked го дава ексепшъна
        //Console.WriteLine(i);
        
        int max = int.MaxValue;
        Console.WriteLine("int max value = {0}", max);
        Console.WriteLine("int max value + 1 = {0}", max + 1);
        Console.WriteLine("int max value + 2 = {0}", max + 2);
        Console.WriteLine("int max value + 3 = {0}", max + 3);
        Console.WriteLine("int min value = {0}", int.MinValue); // int си се превърта просто
        Console.WriteLine("int max value * 20000 = {0}", max * 20000); // дава някакъв грешен резултат
        //int overmax = max * 20000;  // но иначе си е грешка "cannot implicity convert type long to int"
        long longmax = (max);
        Console.WriteLine("int max value * 20000 = {0}",longmax * 20000); // с long записа вече си работи ок
        //checked
        //{
        //    Console.WriteLine("int max value * 20000 = {0}", max * 20000);//отново, но този път...
        //    // check-a ни показва грешката и на конзолата резултатът гърми
        //}
        checked
        {
            Console.WriteLine("int max value + 2 = {0}", max + 2); // пак го повтаряме този ред но вече като checked
            //check-a ни посочва, че имаме епсепшън, коeто не позволява да се "превърти" стойността на int max- и конзолата си гърми, вместо да изписва грешни аритметики :)
            // "Arithmetic operation resulted in an overflow."
        }

    }
}

