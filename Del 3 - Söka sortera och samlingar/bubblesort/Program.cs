using System;

namespace bubblesort
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] array = CreateArray(20);
            Console.WriteLine("Unsorted array:");
            PrintArray(array);

            BubbleSort(array);
            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
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

        static void BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - (i + 1); j++)
                {
                    temp = array[j];
                    if (array[j] > array[j + 1])
                    {
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
