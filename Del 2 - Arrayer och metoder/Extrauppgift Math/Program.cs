using System;

/*
 * Från https://www.howtocreate.co.uk/php/leapyear.php:
 *
 * "Note, the years 0 BC and 0 AD do not exist, they will be treated as 1 AD and 1 BC respectively
 * Rules: Leap years occur on years where the second two digits (AD only) are divisible by 4.
 * In the event of the last two digits being 00, the first two digits must also be divisible by 4 for the year to be a leap year.
 * For BC, counting starts at 1, so there is no year 0.
 * This means that the leap years are offset by 1 and can be calculated by the same method as above, but with the year number increased by 1."
 */

namespace Extrauppgift_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int gregorianYear = -5510;  
            int byzantineYear = 0; // 7530
            
            while (gregorianYear < DateTime.Now.Year)
            {
                bool BC = gregorianYear <= 0;
                
                if (gregorianYear % 4 == 0 && (gregorianYear % 100 != 0 || gregorianYear % 400 == 0)) // Se kommentar övan
                {
                    Console.WriteLine($"Gregoriansk: {(!BC ? gregorianYear : gregorianYear - 1)}");
                    Console.WriteLine($"Bysantinsk: {(!BC ? byzantineYear -1: byzantineYear - 2)}\n");
                }

                gregorianYear += 1;
                byzantineYear += 1;
            }
        }
    }
}