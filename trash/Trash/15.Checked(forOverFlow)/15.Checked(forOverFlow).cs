//C# statements can execute in either checked or unchecked context. 
//In a checked context, arithmetic overflow raises an exception. 
//In an unchecked context, arithmetic overflow is ignored and the result is truncated.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Checked
    {
        static void Main()
        {
            Console.Title = "15. Checked";
            int i = int.MaxValue;
            Console.WriteLine(i);
            checked
            {
                i += 20;
                Console.WriteLine(i);// boom: OverflowException
                // "Arithmetic operation resulted in an overflow."
            }
        }
    }
