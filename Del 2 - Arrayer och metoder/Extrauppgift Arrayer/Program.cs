using System;
using System.Collections.Generic;
using System.Linq;
#nullable enable

namespace Extrauppgift_Arrayer
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            // PirateLangEncrypt();
            // CaesarEncrypt(new [] {1, 2, 3});
            // CaesarDecrypt();
            PirateLangDecrypt();
        }

        static void PirateLangEncrypt()
        {
            string indata = Input("Skriv något: ", s => s);
            string result = "";
            char[] consonants =
                {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x'};
            foreach (char letter in indata.ToLower())
            {
                result += consonants.Contains(letter) ? $"{letter}o{letter}" : letter.ToString();
            }

            Console.WriteLine($"\n{result}");
        }

        static void CaesarEncrypt(int[] key)
        {
            string indata = Input("Skriv något: ", s => s.ToLower());
            string result = "";

            const int unicodeOffset = 97;
            const int nLetters = 26;
            int keyPos = 0;
            for (int i = 0; i < indata.Length; i++)
            {
                char l = indata[i];
                if (!char.IsLetter(l))
                {
                    result += l;
                    continue;
                }

                result += (char) (unicodeOffset + (l - unicodeOffset + key[keyPos % key.Length]) % nLetters);
                keyPos++;
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

            List<int> key = new List<int>();

            const int nLetters = 26;
            for (int i = 0; i < enc.Length; i++)
            {
                char e = enc[i];
                char d = dec[i];

                if (!char.IsLetter(e)) continue;
                key.Add((nLetters + (e - d)) % nLetters);
            }

            for (int i = 1; i <= key.Count; i++)
            {
                List<int> looping = Enumerable
                    .Repeat(
                        key.GetRange(0, i),
                        (int) Math.Ceiling(key.Count / (double) i) + 1
                    )
                    .SelectMany(a => a)
                    .ToList();

                if (!looping.GetRange(0, key.Count).SequenceEqual(key)) continue;

                Console.WriteLine($"\nNyckel: {string.Join(' ', key.GetRange(0, i))}");
                return;
            }
        }

        static void PirateLangDecrypt()
        {
            var enc = Input("Skriv något krypterat: ", s => s.ToLower().GetEnumerator());
            string dec = "";
            char[] consonants =
                {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x'};
            while (enc.MoveNext())
            {
                char current = enc.Current;
                if (consonants.Contains(current))
                {
                    enc.MoveNext();
                    enc.MoveNext();
                }

                dec += current;
            }

            Console.WriteLine($"\n{dec}");
        }
    }
    
    public class MainSuperclass
    {
        public static T Input<T>(string prompt, Func<string, T> parser)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new ArgumentNullException();
                    }

                    var parsed = parser(input);
                    return parsed;
                }
                catch (Exception e)
                {
                    string errMsg = $"Ogiltig input: \"{input}\"\nFel: {e.Message}";
                    Console.WriteLine($"{errMsg}\n");
                }
            }
        }
    }
}