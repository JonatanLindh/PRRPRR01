#nullable enable
using System;
using System.Diagnostics;

namespace Övning_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = Input("Täljare: ", int.Parse);
            int denominator = Input("Nämnare: ", int.Parse);

            int whole = numerator / denominator;

            int newNumerator = numerator % denominator;
            string ansFrac = (newNumerator == 0) ? "" : $" {newNumerator}/{denominator}";
            string ansWhole = whole == 0 ? "" : $" {whole}";


            Console.WriteLine($"\n{numerator}/{denominator} blir{ansWhole}{ansFrac} i blandad form");
        }

        // Denna metoden har jag skapat själv och är till för att hantera fel vid inmatning och konvertering
        // https://github.com/JonatanLindh/PRRPRR01/blob/master/CustomFunctions.cs
        private static T Input<T>(string prompt, Func<string, T> parser)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new Exception();
                    }

                    var parsed = parser(input);
                    return parsed;
                }
                catch (Exception e)
                {
                    string errMsg = e switch
                    {
                        OverflowException => $"Kunde inte konvertera \"{input}\" till {typeof(T).Name} (overflow).",
                        _ => $"Kunde inte konvertera \"{input}\" till {typeof(T).Name}."
                    };
                    Console.WriteLine($"{errMsg}\n");
                }
            }
        }
    }
}