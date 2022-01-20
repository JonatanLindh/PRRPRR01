using System;
using Superclasses;

namespace Uppgift_38
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int num = Input("Ange ett tal: ", s => int.Parse(s));
            Console.WriteLine(square(num));
        }

        static int square(int num)
        {
            return num * num;
        }
    }
}
