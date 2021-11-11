#nullable enable

using System;
using System.Text.RegularExpressions;
using Superclasses; // https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%202%20-%20Arrayer%20och%20metoder/Superclasses/Class1.cs

namespace Uppgift_14
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            string email = Input("Mail: ", s => s);
            Console.WriteLine();
            
            Regex re = new Regex(@"^.+@.+\..+$");
            // Regexförklaring: https://regex101.com/r/rrZeGw/2
            Console.WriteLine(re.IsMatch(email) ? "Godkänd" : "Ej godkänd");
        }
    }
}