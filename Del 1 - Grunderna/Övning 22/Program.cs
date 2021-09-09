using System;

namespace Övning_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saldo på konto (kr): ");
            int balance = int.Parse(Console.ReadLine());
            
            Console.Write("Ränta (%): ");
            double interest = 1 + int.Parse(Console.ReadLine()) / 100.0;
            
            Console.Write("Mål (kr): ");
            int goal = int.Parse(Console.ReadLine());

            int years = (int) Math.Ceiling(Math.Log(goal / balance, interest));
            double finalBalance = balance * Math.Pow(interest, years);
            
            Console.WriteLine($"\nDet kommer att ta {years} år innan saldot når {finalBalance :f2}");


        }
    }
}