using System;
using System.Collections.Generic;

class StringSplit
{
    static void Main()
    {
        Console.Title = "StringSplit";

        //string bla = Console.ReadLine();
        //string[] text = bla.Split(' ');
        //foreach (string symbol in text)
        //{
        //    Console.Write(symbol);
        //}

        //Console.WriteLine("\n");

        //bla = "dog cat hug!";
        //text = bla.Split(' ');
        //foreach (string symbol in text)
        //{
        //    Console.Write(symbol);
        //}

        //Console.WriteLine("\n");

        string allLangs = "C#, Java; HTML, CSS; PHP, JavaScript; SQL";
        string[] langs = allLangs.Split(new char[] { ',', ' ', ';', '!' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var lang in langs)
        {
            Console.WriteLine(lang);
        }

        Console.WriteLine();
        Console.WriteLine("Langs = " + string.Join(", ", langs));

        Console.WriteLine("   \n\n Software University   ".Trim());  // USE OF TRIM!!! - отрязва отпред и отзад 
                                                                     // white space-овете и новите редове "\n\n"           
        string numStr = "1, 12,  123;5; 562!!!402  ";
        
        
        //string[] numsStr = numStr.Split(',', ' ', '!', ';');
        
        //int[] nums = new int[numsStr.Length];
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    nums[i] = int.Parse(numStr[i]); ---- towa gurmi tuk, ne moje da parsne, za6toto imame prazni elementi
        //}



        // pravim su6toto, no ve4e se podsigurqvame:

        string[] numsStr = numStr.Split(new char[] {',', ' ', '!', ';'}, StringSplitOptions.RemoveEmptyEntries);
        

        int[] nums = new int[numsStr.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(numsStr[i]);
            Console.WriteLine("nums[{0}] = {1}", i, nums[i]);
        }
    }
}
