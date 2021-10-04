#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */


namespace Övning_37
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            // Validerar att räknesätt ör +-*/
            char[] ops = {'+', '-', '*', '/'};
            Func<string, char> operatorParser = CreateParser(char.Parse, onlyAllowed: ops, errMsg: "Okänt räknesätt.");

            // Tillåter inte 0
            string div0ErrMsg = "Tal 2 kan inte vara 0 p.g.a. division";
            Func<string, double> not0Parser = CreateParser(double.Parse, new double[] {0}, errMsg: div0ErrMsg);

            double num1 = Input("Första talet: ", double.Parse);
            char op = Input("Räknesätt (+-*/): ", operatorParser);
            double num2 = Input("Andra talet: ", (op == '/') ? not0Parser : double.Parse);

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