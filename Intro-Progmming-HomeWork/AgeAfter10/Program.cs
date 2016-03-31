using System;

namespace AgeAfter10
{
    class Age
    {
        static void Main()
        {
            DateTime userBirthday = DateTime.Parse(Console.ReadLine());
            DateTime timeToday = DateTime.Now;
            long period = timeToday.Subtract(userBirthday).Ticks;
            int years = new DateTime(period).Year - 1;
            Console.WriteLine(years);
            int futureYears = years + 10;
            Console.WriteLine(futureYears);
        }
    }
}

        