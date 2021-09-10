#nullable enable
using System;

namespace Övning_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double depth = Input("Mönsterdjup (mm): ", double.Parse);
            string ans = (depth >= 1.6) ? "\nLagligt" : $"\n{1.6 - depth} mm saknas";
            Console.WriteLine(ans);
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