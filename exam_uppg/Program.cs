using System;
using System.Collections.Generic;

namespace exam_uppg
{
    class Program : Game
    {

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nVälkommen till Rickards källare där du kan spela bort äganderätten till din förstfödde!");
            Console.Write($"Hur många lottorader vill du spela? Varje rad kostar {Lotto.PRICE} kr: ");
            int numberOfLottoRows = int.Parse(Console.ReadLine());
            int totalPrice = numberOfLottoRows * Lotto.PRICE;

            Console.Write("Vill du även spala på Lotto 2? (j/n): ");
            bool playLotto2 = Console.ReadLine().ToLower() == "j";
            totalPrice *= playLotto2 ? 2 : 1;

            Console.Write($"Vill du spela Joker? En Jokerrad kostar {Joker.PRICE} kr. (j/n): ");
            bool playJoker = Console.ReadLine().ToLower() == "j";
            totalPrice += playJoker ? Joker.PRICE : 0;

            Console.WriteLine($"\nTotal kostnad: {totalPrice} kr");

            // Play Lotto 1 if user bought at least 1 row
            if (numberOfLottoRows > 0)
            {
                Lotto lotto = new Lotto(numberOfLottoRows);
                lotto.Play(1);

                // Play Lotto 2 if user wants
                if (playLotto2) lotto.Play(2);
            }

            // Play Joker if user wants
            if (playJoker) Joker.Play();
        }
    }

    class Game
    {
        public static void PrintGreen(int number)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" {number} ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintYellow(int number)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" {number} ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintDivider()
        {
            Console.WriteLine("\n-----------------------------------------------------");
        }
    }

    class Lotto : Game
    {
        public const int PRICE = 3;
        private static Random rnd = new Random();

        private List<List<int>> rows = new List<List<int>>();

        public Lotto(int nrRows)
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < nrRows; i++)
            {
                temp.Clear();
                for (int j = 0; j < 7; j++)
                {
                    int number = rnd.Next(1, 36);
                    while (temp.Contains(number))
                    {
                        number = rnd.Next(1, 36);
                    }
                    temp.Add(number);
                }
                BubbleSort(temp);
                rows.Add(temp.GetRange(0, 7));
            }
        }

        public void Play(int gameNr)
        {

            List<int> lottoNumbers = new List<int>();
            List<int> extraNumbers = new List<int>();
            List<int> temp = new List<int>();

            for (int i = 0; i < 11; i++)
            {
                int number = rnd.Next(1, 36);
                while (temp.Contains(number))
                {
                    number = rnd.Next(1, 36);
                }
                temp.Add(number);
            }

            lottoNumbers = temp.GetRange(0, 7);
            extraNumbers = temp.GetRange(7, 4);

            BubbleSort(lottoNumbers);
            BubbleSort(extraNumbers);

            this.PrintLotto(gameNr, lottoNumbers, extraNumbers);
        }

        static void BubbleSort(List<int> list)
        {
            int temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - (i + 1); j++)
                {
                    temp = list[j];
                    if (list[j] > list[j + 1])
                    {
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        void PrintLotto(int gameNr, List<int> lottoNumbers, List<int> extraNumbers)
        {
            Console.WriteLine($"\n\nRätt Lottorad dragning {gameNr}\t\t\t\t\tTilläggsnummer");
            for (int i = 0; i < lottoNumbers.Count; i++)
            {
                PrintGreen(lottoNumbers[i]);
                Console.Write("\t");
            }
            Console.Write("\t");
            for (int i = 0; i < extraNumbers.Count; i++)
            {
                PrintYellow(extraNumbers[i]);
                Console.Write("\t");
            }
            Console.WriteLine("\n\n");

            (int normal, int extra) = (0, 0);

            for (int i = 0; i < this.rows.Count; i++)
            {
                (normal, extra) = (0, 0);
                Console.WriteLine($"Din lottorad nr {i + 1}");
                for (int j = 0; j < 7; j++)
                {
                    if (lottoNumbers.Contains(rows[i][j]))
                    {
                        PrintGreen(rows[i][j]);
                        normal++;
                    }
                    else if (extraNumbers.Contains(rows[i][j]))
                    {
                        PrintYellow(rows[i][j]);
                        extra++;
                    }
                    else
                    {
                        Console.Write($" {rows[i][j]} ");
                    }
                    Console.Write("\t");
                }
                Console.WriteLine($"\tOrdinarie rätt: {normal}\tExtra rätt: {extra}\n");
            }
            PrintDivider();
        }
    }

    class Joker : Game
    {
        public const int PRICE = 10;
        static Random rnd = new Random();

        public static void Play()
        {
            int[] correctRow = new int[7];
            int[] playerRow = new int[7];
            for (int i = 0; i < correctRow.Length; i++)
            {
                correctRow[i] = rnd.Next(1, 10);
                playerRow[i] = rnd.Next(1, 10);
            }

            int scoreLeft = CalcScoreLeft(correctRow, playerRow);
            int scoreRight = CalcScoreRight(correctRow, playerRow);

            Console.WriteLine("\n\nRätt Jokerrad");
            for (int i = 0; i < correctRow.Length; i++)
            {
                PrintGreen(correctRow[i]);
                Console.Write("\t");
            }
            Console.WriteLine("\n\nDin Jokerrad");
            for (int i = 0; i < correctRow.Length; i++)
            {
                if (correctRow[i] == playerRow[i])
                {
                    PrintYellow(playerRow[i]);
                }
                else
                {
                    Console.Write($" {playerRow[i]} ");
                }
                Console.Write("\t");
            }
            Console.WriteLine($"\t Rätt från vänster: {scoreLeft}\t Rätt från höger: {scoreRight}");
        }

        static int CalcScoreLeft(int[] correctRow, int[] playerRow)
        {
            int score = 0;
            while (correctRow[score] == playerRow[score]) score++;
            return score;
        }

        static int CalcScoreRight(int[] correctRow, int[] playerRow)
        {
            int score = 0;
            for (int i = correctRow.Length - 1; i >= 0; i--)
            {
                if (correctRow[i] == playerRow[i]) score++;
                else break;
            }
            return score;
        }
    }
}
