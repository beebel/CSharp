// Problem 7.	 Quotes in Strings
//
// Declare two string variables and assign them with following value:
//
// The "use" of quotations causes difficulties.
//
// Do the above in two different ways: with and without using quoted strings. 
// Print the variables to ensure that their value was correctly defined.

using System;

    class QuotesInStrings
    {
        static void Main()
        {
            Console.Title = "07. Quotes in Strings";
            string withQuotation = @"The ""use"" of quotations causes difficulties.";
            string withoutQuotation = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("with quotation:      {0}", withQuotation);
            Console.WriteLine("without quotation:   {0}\n", withoutQuotation);
        }
    }
