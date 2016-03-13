using System;

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
        int a = 5;
        int b = 10;

        Console.WriteLine("In the begining a is " + a + " and b is " + b);
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("In the begining a is " + a + " and b is " + b);
        }
    }

