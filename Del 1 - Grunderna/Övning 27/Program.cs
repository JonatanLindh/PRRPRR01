#nullable enable
using System;

namespace Övning_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal 1: ", int.Parse);
            int num2 = Input("Tal 2: ", int.Parse);

            string ans = (num1, num2) switch
            {
                _ when num1 == num2 => $"Talen är lika stora",
                _ when num1 < num2 => $"{num1} är minst",
                _ when num1 > num2 => $"{num2} är minst",
                _ => "???"
            };
            
            Console.WriteLine($"\n{ans}");
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