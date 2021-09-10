using System;

namespace Övning_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "hejhej";
            Console.Write("Lösenord: ");
            string attempt = Console.ReadLine();
            Console.WriteLine((attempt == password) ? "Rätt!" : "Fel :(");
        }
    }
}