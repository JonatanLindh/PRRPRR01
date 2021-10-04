#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Superclasses
{
    public class MainSuperclass
    {
        public static T Input<T>(string prompt, Func<string, T> parser)
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
                    string errMsg = $"Ogiltig input: \"{input}\"\nFel: {e.Message}";
                    Console.WriteLine($"{errMsg}\n");
                }
            }
        }
        
        public static Func<string, T> CreateParser<T>(Func<string, T> baseParser,
            T[]? notAllowed=null, T[]? onlyAllowed=null, string? errMsg=null) where T : notnull
        {
            return s =>
            {
                T parsed = baseParser(s);
                if (onlyAllowed != null && !onlyAllowed.Contains(parsed))
                {
                    throw new Exception((errMsg != null) ? errMsg : $"Input måste vara någon av dessa: {onlyAllowed}");
                }
                
                if (notAllowed != null && notAllowed.Contains(parsed))
                {
                    throw new Exception((errMsg != null) ? errMsg : $"Input får inte vara någon av dessa: {onlyAllowed}");
                    
                }

                return parsed;
            };
        }
    }
}