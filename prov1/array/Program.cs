using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int throws = 100;
            int[] dice = new int[throws];
            Random rnd = new Random();
            for (int i = 0; i < throws; i++)
            {
                dice[i] = rnd.Next(1, 7);
                Console.Write("Kast\t{0}\t{1}\t", i + 1, dice[i]);
                Console.WriteLine(dice[i] switch
                {
                    1 => "Jättedåligt",
                    2 => "Ganska dåligt",
                    3 or 4 => "OK",
                    5 => "Ganska bra",
                    6 => "Jättebra",
                    _ => "Fel"
                });
            }

            int tot = 0;
            foreach (int value in dice)
            {
                tot += value;
            }
            Console.WriteLine("\nSumma: {0}", tot);

            double mean = tot / (double)throws;
            Console.WriteLine("\nMedelvärde: {0}", mean);

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
