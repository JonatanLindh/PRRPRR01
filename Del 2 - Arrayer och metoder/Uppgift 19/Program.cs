#nullable enable

using System;
using System.Text.RegularExpressions;
using
    Superclasses; // https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%202%20-%20Arrayer%20och%20metoder/Superclasses/Class1.cshttps://github.com/JonatanLindh/PRRPRR01/blob/master/Del%202%20-%20Arrayer%20och%20metoder/Superclasses/Class1.cs

namespace Uppgift_19
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            Regex re = new Regex(@"^([a-zA-ZåäöÅÄÖ]+) ([a-zA-ZåäöÅÄÖ]+), (\d+), ([a-zA-ZåäöÅÄÖ]+), ([a-zA-ZåäöÅÄÖ]+)$");
            // Regexförklaring: https://regex101.com/r/39apaT/1
            
            string inp = Input("förnamn efternamn, ålder, stad, yrke: ", s =>
            {
                if (!re.IsMatch(s))
                {
                    throw new Exception("Fel formatering på indata");
                }

                return s;
            });
            var m = re.Match(inp).Groups;
            Console.WriteLine($"\n{m[2]}, {m[1]}\n---\nÅlder: {m[3]}\nStad: {m[4]}\nYrke: {m[5]}");
        }
    }
}