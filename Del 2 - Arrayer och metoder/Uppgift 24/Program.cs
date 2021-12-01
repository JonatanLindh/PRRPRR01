#nullable enable
using System;

namespace Uppgift_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int found = 0;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            
            if (DateTime.Now.Day < 13)
            {
                month -= 1;
            }
            
            while (found < 5)
            {
                while (month > 0)
                {
                    if (new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday)
                    {
                        found++;
                        Console.WriteLine($"{year}-{month}-13");
                    }
                    month--;
                }
                month = 12;
                year -= 1;
            }
        }
    }
}