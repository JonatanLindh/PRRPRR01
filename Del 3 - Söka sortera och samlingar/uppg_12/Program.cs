using System;
using System.Collections.Generic;

namespace uppg_12
{
    class Program
    {
        static List<string> todo = new List<string>();

        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());

                if (option == 0)
                {
                    //Anropa metod som skriver ut listan
                    PrintList();
                }
                else if (option == 1)
                {
                    //Anropa en metod som lägger till i lista
                    AddItem();
                }
                else if (option == 2)
                {
                    //Anropa metod som tar bort översta i lista
                    todo.RemoveAt(0);
                }
                else if (option == 3)
                {
                    //Anropa metod som tar bort på viss position
                    RemoveItem();
                }
                else if (option == 4)
                {
                    //Anropa metod som lägger till på viss position
                    InsertItem();
                }

            } while (option != -1);
        }

        static void PrintMenu()
        {
            Console.WriteLine("********* Menu *********");
            Console.WriteLine("* 0. View ToDo-list *");
            Console.WriteLine("* 1. Add item *");
            Console.WriteLine("* 2. Remove item *");
            Console.WriteLine("* 3. Remove item #n *");
            Console.WriteLine("* 4. Insert at #n *");
            Console.WriteLine("* -1. Exit *");
            Console.WriteLine("************************");
        }

        static void PrintList()
        {
            for (int i = 0; i < todo.Count; i++)
            {
                Console.Write(i + ". " + todo[i] + "\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddItem()
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            todo.Add(item);
        }

        static void RemoveItem()
        {
            Console.Write("Enter item #: ");
            int item = int.Parse(Console.ReadLine());
            todo.RemoveAt(item);
        }

        static void InsertItem()
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            todo.Insert(position, item);
        }

    }
}
