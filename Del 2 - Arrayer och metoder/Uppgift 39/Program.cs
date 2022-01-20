using System;
using Superclasses;

namespace Uppgift_39
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double num = Input("Ange bas: ", s => double.Parse(s));
            double exponent = Input("Ange exponent: ", s => double.Parse(s));
            Console.WriteLine(Math.Pow(num, exponent));
        }
    }
}
