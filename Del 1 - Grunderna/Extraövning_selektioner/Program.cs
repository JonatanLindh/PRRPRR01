#nullable enable
using System;
using System.ComponentModel;
using System.Linq;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Extraövning_selektioner
{
    class Program : MainSuperclass
    {
    
        static void Main(string[] args)
        {
            byte[] summerMonths = new byte[] {5, 6, 7, 8, 9};
            
            Func<string, byte> monthParser = CreateParser(byte.Parse, onlyAllowed: new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12});
            Func<string, string> roadStateParser = CreateParser(s => s, onlyAllowed: new string[] {"sommar", "vinter"});

            bool summerMonth = summerMonths.Contains(Input("Månad: ", monthParser));
            bool summerRoadState = Input("Väglag (vinter/sommar): ", roadStateParser) == "sommar";
            
            // sommarmånad -> krav på sommardäck, förbud vinter
            //     om inte vinterväglag -> tillåtet med båda
            //
            // vinter -> krav på vinterdäck, förbud sommardäck
            //     om inte sommarväglag -> tillåtet med båda
            
            (string summerTire, string winterTire) = (summerMonth, summerRoadState) switch
            {
                _ when summerMonth != summerRoadState => ("Tillåtet med", "Tillåtet med"),
                (true, _) => ("Krav på", "Förbud på"),
                (false, _) => ("Förbud på", "Krav på")
            };
            
            Console.WriteLine($"\n{winterTire} vinterdäck.\n{summerTire} sommardäck.");
        }
    }
}