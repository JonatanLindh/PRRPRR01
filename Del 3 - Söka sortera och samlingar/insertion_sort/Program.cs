using System;

namespace insertion_sort
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] array = CreateArray(20);
            Console.WriteLine("Unsorted array:");
            PrintArray(array);

            InsertionSort(array);
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

        static void InsertionSort(int[] array)
        {
            int temp, idx;

            for (int i = 1; i < array.Length; i++)
            {
                idx = i;
                while (array[idx] < array[idx - 1])
                {
                    temp = array[idx];
                    array[idx] = array[idx - 1];
                    array[idx - 1] = temp;
                    idx--;
                    if (idx == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
