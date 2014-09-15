// Problem 16.**    Bit Exchange (Advanced)
//
// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned 
// integer. The first and the second sequence of bits may not overlap. Examples:
//
//  n	        p	q	k	binary representation of n	        binary result	                    result
//--------------------------------------------------------------------------------------------------------------
//  1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
//  4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
//  2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
//  987654321	2	8	11	-	                                -	                                overlapping
//  123456789	26	0	7	-	                                -	                                out of range
//  33333333333	-1	0	33	-	                                -	                                out of range

//Трябва да въведеш 4 параметъра. 
//n - числото
//p - тези битовете ще бъдат разменени с битовете на q
//q - тези битовете ще бъдат разменени с битовете на p
//k - колко бита ще се разменят
 
//т.е. p и q ще си разменят битовете.
 
//Пример: 
// n	        p	q	k
//2369124121	2	22	10
  
//Ще се разменят 10 бита с позиции 2 и 22, на числото 2369124121

using System;

class ExchangeBitsFirst
{
    static void Main()
    {
        Console.Title = "16.** Bit Exchange (Advanced)";
        uint mask = 1;
        uint bit1;
        uint bit2;
        uint number1;
        for (int count = 0; count < 6; count++)
        {
            Console.Write("Enter a number to exchange bits: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Now enter the starting lower bit (p): ");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("Now enter the starting higher bit (q): ");
            byte q = byte.Parse(Console.ReadLine());
            Console.Write("And finally, enter the number of bits to be exchanged (k): ");
            byte k = byte.Parse(Console.ReadLine());
            Console.WriteLine("{0} : Original number : {1} in decimal", Convert.ToString(number, 2).PadLeft(32, '0'), number);
            for (byte i = 0; i < k; i++, p++, q++) //k пъти се изпълнява и проверява k пъти p и q (и следващите ги к-1 на брой битове) евентуално променяйки ги (само ако са различни, иначе няма смисъл- резултатът би бил същият)- общо k * 2 на брой битове.
            {                  // почва да търси стойностите на двата начални бита на позиции p и q в числото number
                mask = mask << p;                 // мести 1-цата на позиция p в маската
                bit1 = (mask & number) >> p;      // излезе стойността на p и си я запазва на 0 позиция в bit1
                mask = mask >> p;                 // връща си 1 обратно до 0 позиция на маската 
                mask = mask << q;                 // мести 1 на позиция q в маската 
                bit2 = (mask & number) >> q;//намира стойността на битa на позиция q и си я запазва на 0 позиция в bit2  
                mask >>= q;                      // и накрая си прибира 1-цата обратно на 0 позиция в маската. 
                if (bit1 != bit2)   // ако са различни, щото няма смисъл да се разменят местата на 1 с 1 или 0 с 0 
                {
                    if (bit1 == 1)  // щом са различни или bit1 = 1 и bit2 = 0 или обратното
                    {
                        checked      // чека обаче не бачка нещо...
                        {
                            number1 = number | (mask << q);
                            number = number1 ^ (mask << p);
                        }
                    }
                    else // if (bit1 != 1), т.е равен на 0
                    {
                        checked
                        {
                            number1 = number | (mask << p);
                            number = number1 ^ (mask << q);
                        }
                    }
                } // върти си се Loop-ът а промените си се трупат в променящия се number
            }
            Console.WriteLine("{0} : Converted number : {1} in decimal\n", Convert.ToString(number, 2).PadLeft(32, '0'), number);   
        }
        
    }// накрая си го печата готовия променен number като число и побитово 
}


//ПОДРОБНО ОБЯСНЕНИЕ КАКВО СЕ СЛУЧВА В if (bit1 != bit2)

//ако, да кажем, числото което сме въвели в двоична изглежда така: 
//number = 000(?)010(?)00
//като 000 (?) (е позицията на първото q) 010 (?) (е позицията на първото p) 00 ---> 000(q)010(p)00 

//if (bit1 == 1)//т.е. p = 1        първи ред:     000(0)010(1)00   ---> number                    втори ред:    000(1)010(1)00   ---> number1   
//{                                              |                                                             ^
//    number1 = number | (mask << q);              000(1)000(0)00   ---> mask << q                               000(0)000(1)00   ---> mask << p
//    number = number1 ^ (mask << p);             ----------------                                              ----------------             
//}                                                000(1)010(1)00   ---> number1 (q сменен)                      000(1)010(0)00   ---> number (и p е сменен)


//else // т.е. q = 1 и p = 0         първи ред:     000(1)010(0)00   ---> number                    втори ред:    000(1)010(1)00   ---> number1  
//{                                               |                                                             ^                                                     
//    number1 = number | (mask << p);               000(0)000(1)00   ---> mask << p                               000(1)000(0)00   ---> mask << q                                            
//    number = number1 ^ (mask << q);              ----------------                                              ---------------- 
//}                                                 000(1)010(1)00   ---> number1 (p сменен)                      000(0)010(1)00   ---> number (и q е сменен)  


//красота <3


// що е checked:

//int i = int.MaxValue -10;
//checked 
//{       
//   i+= 20;    // boom: OverflowException
//}             // "Arithmetic operation resulted in an overflow."
//