using System;

    class ObjectToString
    {
        static void Main(string[] args)
        {
        string first = "Hello";
        string second = "World";
        object all = first + " " + second;
        string both = (string)all;
        Console.WriteLine(all);
        Console.WriteLine(both);
        }
    }

