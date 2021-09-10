using System;

class CustomFunctions
{
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