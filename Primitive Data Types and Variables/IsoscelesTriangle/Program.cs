using System;
using System.Text;      // Should be added if you want to use Console.OutputEncoding //
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;                   // To use this library put first using System.Text; //
        char copyright = '\u00A9';                               // This is the symbol c //
        Console.WriteLine(" " + " " + " " + copyright);         // use " " to put the symbol in to the position that you want //
        Console.WriteLine(" " + " " + copyright + " " + copyright);
        Console.WriteLine(" " + copyright + " " + " " + " " + copyright);
        Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
    }
    }

