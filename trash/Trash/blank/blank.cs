// малко бързи комбинации:

// ctr + k + d - форматиране във VS
// shift (задържамe) + ctr (задържамe) + ляво/дясно - мести се (маркираме) от дума на дума
// alt (задържамe) + нагоре/ надолу - местим целия ред на който сме.
// shift (задържамe) + alt - все едно маркираме с мишката- удобно за маркиране в колона символи от няколко различни реда
// ctr + c на празно поле, след написаното, без да сме маркирали нищо; след това ctr  + v пак така напразно място-
//        това ни копира целия ред колкото пъти си искаме x(ctr + v) 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class blank
{
    static void Main()
    {
        Console.Title = "blank";

        decimal value = 1.80m;
        int discount = 30;

        decimal quantity = 3m;



        Console.WriteLine(value * quantity - (value * quantity * discount) / 100);
    }
}