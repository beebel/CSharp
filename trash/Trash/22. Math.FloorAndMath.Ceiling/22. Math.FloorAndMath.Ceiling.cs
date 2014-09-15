using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MathFloorAndMathCeiling
{
    static void Main()
    {
        Console.Title = "22. Math.Floor And Math.Ceiling";

        double n = 1.934;

        Console.WriteLine(Math.Ceiling(n));  // закръгля нагоре до цяло число
        Console.WriteLine(Math.Floor(n));    // закръгля надолу до цяло число

        var p = Math.Ceiling(n);

        Console.WriteLine(p.GetType());    // но числото, всъщност си остава от тип double, не става на Int
    }
}
