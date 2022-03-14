using System;

namespace binary_search
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int totSeqSteps = 0;
            int totBinSteps = 0;
            (int, int) results;

            for (int i = 0; i < 1000; i++)
            {
                results = PerformSearches(false);
                totSeqSteps += results.Item1;
                totBinSteps += results.Item2;
            }

            Console.WriteLine($"Antal steg sekventiell sökning, medel: {totSeqSteps / 1000.0}");
            Console.WriteLine($"Antal steg binär sökning, medel: {totBinSteps / 1000.0}");
        }
        static (int, int) PerformSearches(bool log = false)
        {
            int[] array = CreateSortedArray(20);
            int searchFor = rnd.Next(0, 100);

            if (log) Console.WriteLine("Array:");
            if (log) PrintArray(array);
            if (log) Console.WriteLine("Letar efter: " + searchFor + "\n");

            int seqSteps = SeqSearch(array, searchFor, log);
            int binSteps = BinSearch(array, searchFor, log);

            return (seqSteps, binSteps);
        }
        static int[] CreateSortedArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            Array.Sort(array);
            return array;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int SeqSearch(int[] array, int searchFor, bool log = false)
        {
            if (log) Console.WriteLine("Sekventiell sökning:");
            int steps = 0;
            for (int i = 0; i < array.Length; i++)
            {
                steps++;
                if (array[i] == searchFor)
                {
                    if (log) Console.WriteLine("Hittade vid index {0} på {1} steg\n", i, steps);
                    return steps;
                }
            }
            if (log) Console.WriteLine("Hittade inte talet på {0} steg\n", steps);
            return steps;
        }

        static int BinSearch(int[] array, int searchFor, bool log = false)
        {
            if (log) Console.WriteLine("Binär sökning:");
            int steps = 0;
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                steps++;
                int mid = (low + high) / 2;
                if (array[mid] == searchFor)
                {
                    if (log) Console.WriteLine("Hittade vid index {0} på {1} steg\n", mid, steps);
                    return steps;
                }
                else if (array[mid] < searchFor)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if (log) Console.WriteLine("Hittade inte talet på {0} steg\n", steps);
            return steps;
        }
    }
}
