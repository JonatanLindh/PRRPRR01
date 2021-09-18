#nullable enable
using System;
using System.Collections.Generic;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */


namespace Övning_37
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            double num1 = Input("Första talet: ", double.Parse);

            // Validerar att räknesätt ör +-*/
            Func<string, char> operatorParser = CreateParser(char.Parse, onlyAllowed: new char[] {'+', '-', '*', '/'},
                errMsg: "Okänt räknesätt.");
            char op = Input("Räknesätt (+-*/): ", operatorParser);

            // Ser till att num2 inte är 0 om räknesätt är division
            Func<string, double> num2Parser = (op == '/')
                ? CreateParser(double.Parse, new double[] {0}, errMsg: "Tal 2 kan inte vara 0 p.g.a. division")
                : double.Parse;
            double num2 = Input("Andra talet: ", num2Parser);

            // Kan endast vara +-*/ pga operatorParser so default behövs inte, stänger därför av varningen
            # pragma warning disable 8509
            double ans = op switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 / num2,
            };
            # pragma warning restore

            Console.WriteLine($"\n{num1} {op} {num2} = {ans}");
        }
    }
}