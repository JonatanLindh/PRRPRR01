#nullable enable
using System;

namespace Övning_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = Input("Vikt (hg): ", double.Parse);
            double hgPrice = Input("Pris (kr/hg): ", double.Parse);

            Console.WriteLine($"\nPris: {((weight >= 5) ? weight * hgPrice * 0.9 : weight * hgPrice) :f2} kr");
        }

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
                        throw new ArgumentNullException();
                    }

                    var parsed = parser(input);
                    return parsed;
                }
                catch (Exception e)
                {
                    string errMsg = $"Kunde inte konvertera \"{input}\" till {typeof(T).Name} \nFel: {e.Message}";
                    Console.WriteLine($"{errMsg}\n");
                }
            }
        }
    }
}