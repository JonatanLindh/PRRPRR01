#nullable enable
using System;
using System.Linq;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */


namespace Övning_39
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            Func<string, bool> yesNoParser = CreateParser(s =>
            {
                char a = char.Parse(s);
                return a switch
                {
                    'Y' or 'y' => true,
                    'N' or 'n' => false,
                    _ => throw new Exception("Måste vara något av följande: Y, y, N, n"),
                };
            });
            
            bool isMale = Input("Är du man? (Y/N): ", yesNoParser);
            bool under30 = Input("Är du under 30 år gammal? (Y/N): ", yesNoParser);
            bool hasChildren = !Input("Har du barn? (Y/N): ", yesNoParser);

            string result = new[] {isMale, under30, hasChildren}.Sum(b => b ? 1 : 0) >= 2
                ? "Grattis, du är kvalificerad"
                : "Sorry, du är inte kvalificerad";
            
            Console.WriteLine($"\n{result}");

        }
    }
}