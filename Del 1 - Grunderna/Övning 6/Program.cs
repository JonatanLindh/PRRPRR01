using System;

namespace Övning_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grader i celsius: ");
            int degCelsius = int.Parse(Console.ReadLine());
            
            double degFahrenheit = 1.8 * degCelsius + 32;
            
            Console.WriteLine($"Grader i Fahrenheit: {degFahrenheit :f2} °F");
        }
    }
}