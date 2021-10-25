using System;
using System.Linq;
using Superclasses;

namespace Extrauppgift_Arrayer
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            PirateLang();
        }

        static void PirateLang()
        {
            string indata = Input("Skriv något: ", s => s);
            string result = "";
            char[] vowels_and_space = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y','Å', 'Ä', 'Ö', ' ' };
            
            foreach (char letter in indata.ToUpper())
            {
                result += vowels_and_space.Contains(letter)
                    ? letter.ToString().ToLower()
                    : $"{letter}o{letter}".ToLower();
            }
            
            Console.WriteLine($"\n{result}");
        }
        
    }
}