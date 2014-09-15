using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class GetType
    {
        static void Main()
        {
            Console.Title = "GetType";
            var a = 5.0;
            Console.WriteLine(a.GetType());
            Type b = typeof(char);
            Console.WriteLine(b);    
        }
    }

