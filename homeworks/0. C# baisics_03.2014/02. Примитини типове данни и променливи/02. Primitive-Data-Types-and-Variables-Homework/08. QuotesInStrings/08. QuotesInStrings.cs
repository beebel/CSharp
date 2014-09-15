// Problem 8.   Quotes in Strings
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
            Console.Title = "08. Quotes in Strings";
            string quoted = @"""The ""use"" of quotations causes difficulties.""";
            string otherWayQuoted = "\"The \"use\" of quotations causes difficulties.\"";
            string notQuoted = "The \"use\" of quotations causes difficulties.";
            string otherWayNotQuoted = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quoted);
            Console.WriteLine(otherWayQuoted);
            Console.WriteLine(notQuoted);
            Console.WriteLine(otherWayNotQuoted);
        }
    }

