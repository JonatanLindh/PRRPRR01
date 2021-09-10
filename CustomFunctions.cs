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