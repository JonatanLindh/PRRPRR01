using System;
using System.Linq;
using Superclasses;

namespace Extrauppgift_Arrayer
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            // PirateLangEncrypt();
            CaesarEncrypt(new [] {1, 2, 3});
            // CaesarDecrypt();
            // Console.WriteLine(-1 % 2);
        }

        static void PirateLangEncrypt()
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

        static void CaesarEncrypt(int[] key)
        {
            string indata = Input("Skriv något: ", s => s.ToLower());
            string result = "";

            const int offset = 97;
            for (int i = 0; i < indata.Length; i++)
            {
                result += Char.IsLetter(indata[i])
                    ? (char) (offset + (((int) indata[i] - offset + key[i % key.Length]) % 26))
                    : indata[i];
            }
            Console.WriteLine($"\n{result}");
        }

        static void CaesarDecrypt()
        {
            string enc = Input("Skriv något krypterat: ", s => s.ToLower());
            string dec = Input("Skriv samma sak men dekrypterat: ", s =>
            {
                if (s.Length != enc.Length)
                {
                    throw new Exception("Kryperad och dekrypterad text måste ha lika många tecken.");
                }

                return s.ToLower();
            });
            
            string result = "";
            
            const int offset = 97;
            for (int i = 0; i < enc.Length; i++)
            {
                char e = enc[i];
                char d = dec[i];
                
            }
            
            Console.WriteLine($"\n{result}");
        }
    }
}