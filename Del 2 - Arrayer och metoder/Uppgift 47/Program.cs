using System;
using System.Text.RegularExpressions;

namespace Uppgift_47
{
    class Program
    {
        static void Main(string[] args)
        {
            KastaTarning(4);
            KastaTarning(2, 8);
            KastaTarning("3T10");
        }

        static int KastaTarning(int throws)
        {
            int sum = 0;
            for (int i = 0; i < throws; i++)
            {
                sum += new Random().Next(1, 7);
            }
            Console.WriteLine(sum);
            return sum;
        }

        static int KastaTarning(int throws, int sides)
        {
            int sum = 0;
            for (int i = 0; i < throws; i++)
            {
                sum += new Random().Next(1, sides);
            }
            Console.WriteLine(sum);
            return sum;
        }
        static int KastaTarning(string command)
        {

            Regex re = new Regex(@"^(\d+)(T)(\d+)$");

            if (!re.IsMatch(command))
            {
                throw new Exception("Fel formatering på indata");
            }

            var m = re.Match(command).Groups;

            int throws = int.Parse(m[1].Value);
            int sides = int.Parse(m[3].Value);

            int sum = 0;
            for (int i = 0; i < throws; i++)
            {
                sum += new Random().Next(1, sides);
            }

            Console.WriteLine(sum);
            return sum;
        }
    }
}
