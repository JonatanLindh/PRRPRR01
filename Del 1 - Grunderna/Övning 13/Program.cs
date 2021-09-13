#nullable enable
using System;
using System.Diagnostics;
using Subclasses;


namespace Övning_13
{
    class Program : Subclasses.MainSubclass
    {
        static void Main(string[] args)
        {
            int numerator = Input("Täljare: ", int.Parse);
            int denominator = Input("Nämnare: ", int.Parse);

            int whole = numerator / denominator;
            int newNumerator = numerator % denominator;

            string ansFrac = (newNumerator == 0) ? "" : $" {newNumerator}/{denominator}";
            string ansWhole = whole == 0 ? "" : $" {whole}";

            Console.WriteLine($"\n{numerator}/{denominator} blir{ansWhole}{ansFrac} i blandad form");
        }
    }
}