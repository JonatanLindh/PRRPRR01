using System;
using System.Linq;

namespace metoder
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] dice = new int[100];
            for (int i = 0; i < dice.Length; i++)
            {
                throwDice(i, dice);
            }
            Console.WriteLine("\nSumma: {0}", dice.Sum());
            double mean = calcMean(dice.Sum(), dice.Length);
            evalMean(mean);
        }

        static void throwDice(int idx, int[] dice)
        {
            dice[idx] = rnd.Next(1, 7);
            Console.Write("Kast\t{0}\t{1}\t", idx + 1, dice[idx]);
            Console.WriteLine(dice[idx] switch
            {
                1 => "Jättedåligt",
                2 => "Ganska dåligt",
                3 or 4 => "OK",
                5 => "Ganska bra",
                6 => "Jättebra",
                _ => "Fel"
            });

        }

        static double calcMean(int tot, int throws)
        {
            double mean = tot / (double)throws;
            Console.WriteLine("\nMedelvärde: {0}", mean);
            return mean;
        }

        static void evalMean(double mean)
        {
            if (mean < 2.5)
            {
                Console.WriteLine("\nMedelvärdet blev oväntat lågt.");
            }
            else if (mean > 3.5)
            {
                Console.WriteLine("\nMedelvärdet blev oväntat högt");
            }
            else
            {
                Console.WriteLine("\nMedelvärdet blev som förväntat");
            }
        }
    }
}
