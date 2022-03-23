using System;
using System.Collections.Generic;

namespace uppg_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word) ? "Palindrome" : "Not palindrome");
        }
        static bool IsPalindrome(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                stack.Push(c);
            }
            foreach (char c in s)
            {
                if (stack.Pop() != c)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
