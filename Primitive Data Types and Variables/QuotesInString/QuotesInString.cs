using System;
class QuotesInString
    {
        static void Main(string[] args)
        {
        string first = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(first);
        string second = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(second);
        }
    }

