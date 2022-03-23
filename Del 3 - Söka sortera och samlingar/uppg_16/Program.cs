using System;
using System.Collections.Generic;

namespace uppg_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int option;

            do
            {
                Console.Clear();
                PrintMenu(queue);
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());

                if (option == 0)
                {
                    //Anropa metod som skriver ut listan
                    AddItem(queue);
                }
                else if (option == 1)
                {
                    //Anropa en metod som lägger till i lista
                    Console.WriteLine("\n\"" + queue.Dequeue() + "\" removed from queue");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }


            } while (option != -1);
        }

        static void PrintMenu(Queue<string> queue)
        {
            Console.WriteLine($"********* Queue - {queue.Count} person *********");
            Console.WriteLine("* 0. Add person *");
            Console.WriteLine("* 1. Remove person *");
            Console.WriteLine("* -1. Exit *");
            Console.WriteLine("************************");
        }

        static void AddItem(Queue<string> queue)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            queue.Enqueue(name);
        }
    }
}
