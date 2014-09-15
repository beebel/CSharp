using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringJoin
{
    static void Main()
    {
        Console.Title = "String.Join()";
        
        string bla = "abcdef";
        bla = String.Join(" ", bla.Skip(2));    // добавя сепарейтър между литералите на един стринг, като ние казваме  
        Console.WriteLine(bla);                 // какъв да е този сепърейтър И със .skip(2) му казваме да почне да 
                                               // я прави тази магия от 3-тия лит. на стринг, тъй като първите два
                                               // искаме да ги пропусне; ако искаме да запазим целия стринг, 
                                              // т.е. да почне да го цепи от буква а пишем:
                                               //bla = String.Join(" ", bla.Skip(0));                                   

        string [] reverse = bla.Split(' ');
        foreach (var letter in reverse)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }                                           
}                                               