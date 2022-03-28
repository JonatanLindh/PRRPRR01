using System;
using System.Collections.Generic;

namespace exam_uppg
{
    class Program
    {

        static void Main(string[] args)
        {
            Game.PrintDivider();
            Console.WriteLine("Välkommen till Rickards källare! Här kan du kan spela bort äganderätten till din förstfödde!");
            Console.Write($"Hur många lottorader vill du spela? Varje rad kostar {Lotto.PRICE} kr: ");
            int lRows = int.Parse(Console.ReadLine()); // Number of lotto rows to play

            Console.Write("Vill du även spela på Lotto 2? (j/n): ");
            bool playL2 = Console.ReadLine().ToLower() == "j"; // true if user wants to play Lotto 2

            Console.Write($"Vill du spela Joker? En Jokerrad kostar {Joker.PRICE} kr. (j/n): ");
            bool playJ = Console.ReadLine().ToLower() == "j"; // true if user wants to play Joker

            // Num rows * price * (2 if Lotto 2, else 1) + (Joker price if Joker)
            int totalPrice = lRows * Lotto.PRICE * (playL2 ? 2 : 1) + (playJ ? Joker.PRICE : 0);

            Console.WriteLine($"\nTotal kostnad: {totalPrice} kr");
            Game.PrintDivider();

            // Play Lotto 1 if user bought at least 1 row
            if (lRows > 0)
            {
                Lotto lotto = new Lotto(lRows);
                lotto.Play(1);

                // Play Lotto 2 if user wants
                if (playL2) lotto.Play(2);
            }

            // Play Joker if user wants
            if (playJ) Joker.Play();
        }
    }

    class Game
    {
        public static Random rnd = new Random();

        // Prints an integer with colored background
        public static void PrintColor(ConsoleColor color, int number)
        {
            Console.BackgroundColor = color;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" {number} ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintDivider()
        {
            Console.WriteLine($"\n{new string('_', 110)}\n");
        }
    }

    // Class for the lotto game and its methods
    class Lotto : Game
    {
        public const int PRICE = 3;

        // List of lists with the users rows
        private List<List<int>> rows = new List<List<int>>();

        // initializes the lotto object with the user's rows, will also be the same for lotto 2
        public Lotto(int nrRows)
        {
            List<int> temp = new List<int>();

            // Generates nrRows rows in a list
            for (int i = 0; i < nrRows; i++)
            {
                temp = GenUniqueRandomNumbers(7); // Generates 7 unique random numbers between 1 and 35 (inlusive)
                BubbleSort(temp); // Sorts the list
                rows.Add(temp.GetRange(0, 7)); // Adds the sorted temp list to the rows list
            }
        }

        // Plays a game of lotto with the previously created rows
        public void Play(int gameNr)
        {

            List<int> lottoNumbers = new List<int>();
            List<int> extraNumbers = new List<int>();

            // Generates 11 unique random numbers between 1 and 35 (inlusive)
            List<int> temp = GenUniqueRandomNumbers(11);

            // Splits the random numbers into ordinary numbers and extra numbers
            lottoNumbers = temp.GetRange(0, 7); // Seven first numbers
            extraNumbers = temp.GetRange(7, 4); // Four last numbers

            // Sorts both sets of numbers
            BubbleSort(lottoNumbers);
            BubbleSort(extraNumbers);

            this.PrintLotto(gameNr, lottoNumbers, extraNumbers);
        }

        // https://en.wikipedia.org/wiki/Bubble_sort
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

        // Generates n unique random numbers between 1 and 35 (inlusive)
        List<int> GenUniqueRandomNumbers(int n)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = rnd.Next(1, 36); // Generates a random number between 1 and 35 (inclusive)
                while (ListContains(temp, number)) // Generates a new one if the number is already in the list
                {
                    number = rnd.Next(1, 36);
                }
                temp.Add(number); // Adds number to the list
            }
            return temp;
        }

        // Checks if a list contains an element
        static bool ListContains<T>(List<T> list, T el)
        {
            foreach (T i in list)
            {
                if (i.Equals(el)) return true;
            }
            return false;
        }

        void PrintLotto(int gameNr, List<int> lottoNumbers, List<int> extraNumbers)
        {
            // Prints the correct row, ordinary with green background, extra with yellow background
            Console.WriteLine($"Rätt Lottorad dragning {gameNr}\t\t\t\t\tTilläggsnummer");
            for (int i = 0; i < lottoNumbers.Count; i++)
            {
                PrintColor(ConsoleColor.Green, lottoNumbers[i]);
                Console.Write("\t");
            }
            Console.Write("\t");
            for (int i = 0; i < extraNumbers.Count; i++)
            {
                PrintColor(ConsoleColor.Yellow, extraNumbers[i]);
                Console.Write("\t");
            }
            Console.WriteLine("\n");

            // Loops through the rows and checks against the generated numbers
            // Loop has 3 local variables: i, ordinary and extra; each set to 0 at the start of the loop
            // Each loop increments i and sets ordinary and extra to 0
            for (int i = 0, ordinary = 0, extra = 0; i < this.rows.Count; i++, (ordinary, extra) = (0, 0))
            {
                Console.WriteLine($"\nDin lottorad nr {i + 1}");
                for (int j = 0; j < 7; j++)
                {
                    // If the number is in the ordinary numbers, set green background
                    if (ListContains(lottoNumbers, rows[i][j]))
                    {
                        PrintColor(ConsoleColor.Green, rows[i][j]);
                        ordinary++;
                    }
                    // If the number is in the extra numbers, set yellow background
                    else if (ListContains(extraNumbers, rows[i][j]))
                    {
                        PrintColor(ConsoleColor.Yellow, rows[i][j]);
                        extra++;
                    }
                    // If the number is not in the ordinary or extra numbers, print the number with no special background
                    else
                    {
                        Console.Write($" {rows[i][j]} ");
                    }
                    Console.Write("\t");
                }

                Console.WriteLine($"\tOrdinarie rätt: {ordinary}\tExtra rätt: {extra}");
            }
            PrintDivider();
        }
    }

    // Class for the joker game and its methods
    class Joker : Game
    {
        public const int PRICE = 10;

        public static void Play()
        {
            // Genarate 2 rows of 7 random numbers between 1 and 9 (inclusive)
            // One row is the correct row, the other is the user's row
            int[] correctRow = new int[7];
            int[] playerRow = new int[7];
            for (int i = 0; i < correctRow.Length; i++)
            {
                correctRow[i] = rnd.Next(1, 10);
                playerRow[i] = rnd.Next(1, 10);
            }

            // Calcutate the scores from both sides
            int scoreLeft = CalcScoreLeft(correctRow, playerRow);
            int scoreRight = CalcScoreRight(correctRow, playerRow);

            // Prints the correct row with numbers having a green background
            Console.WriteLine("Rätt Jokerrad");
            for (int i = 0; i < correctRow.Length; i++)
            {
                PrintColor(ConsoleColor.Green, correctRow[i]);
                Console.Write("\t");
            }

            // Prints the user's row with correct numbers having a yellow background
            Console.WriteLine("\n\nDin Jokerrad");
            for (int i = 0; i < correctRow.Length; i++)
            {
                if ((scoreLeft > i) || (scoreRight >= (correctRow.Length-i)))
                {
                    PrintColor(ConsoleColor.Green, playerRow[i]);
                }
                else if (correctRow[i] == playerRow[i])
                {
                    PrintColor(ConsoleColor.Yellow, playerRow[i]);
                }
                else
                {
                    Console.Write($" {playerRow[i]} ");
                }
                Console.Write("\t");
            }
            Console.WriteLine($"\t Rätt från vänster: {scoreLeft}\t Rätt från höger: {scoreRight}");
            PrintDivider();
        }

        // Check number of correct numbers from the left side
        static int CalcScoreLeft(int[] correctRow, int[] playerRow)
        {
            int score = 0;
            while (correctRow[score] == playerRow[score]) score++;
            return score;
        }

        // Check number of correct numbers from the right side
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
