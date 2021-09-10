#nullable enable
using System;

namespace Övning_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal 1: ", int.Parse);
            int num2 = Input("Tal 2: ", int.Parse);
            
            Console.WriteLine($"\nStörst: {((num1 > num2) ? num1 : num2)}");
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