using System;
using System.Linq;

namespace HW_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            void DeleteLongestWord(string text)
            {
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var longestWord = wordsOfText.OrderBy(_ => _.Length).LastOrDefault();
                text = text.Replace(longestWord, string.Empty);

                Console.WriteLine("Text after deletion:");
                Console.WriteLine();
                Console.WriteLine(String.Join(" ", text));
            }

            void SwapWords(string text)
            {
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var longestWord = wordsOfText.OrderBy(_ => _.Length).LastOrDefault();
                var shortestWord = wordsOfText.OrderBy(_ => _.Length).FirstOrDefault();

                int LengthOfShort = wordsOfText.Select(_ => _.Length).Min();
                int LengthOfLong = wordsOfText.Select(_ => _.Length).Max();

                int indexOfMin = text.IndexOf(shortestWord);
                int indexOfMax = text.IndexOf(longestWord);

                if (indexOfMin < indexOfMax)
                {
                    text = text.Insert(indexOfMax, shortestWord)
                               .Remove(indexOfMax + LengthOfShort, LengthOfLong)
                               .Insert(indexOfMin, longestWord)
                               .Remove(indexOfMin + LengthOfLong, LengthOfShort);
                }
                else
                {
                    text = text.Insert(indexOfMin, longestWord)
                               .Remove(indexOfMin + LengthOfLong, LengthOfShort)
                               .Insert(indexOfMax, shortestWord)
                               .Remove(indexOfMax + LengthOfShort, LengthOfLong);
                }

                Console.WriteLine("Text after swapping:");
                Console.WriteLine();
                Console.WriteLine(text);
            }

            void CountChar(string text)
            {
                var amountOfLetters = text.Where(char.IsLetter).Count();
                var amountOfPunctuations = text.Where(char.IsPunctuation).Count();

                Console.WriteLine($"String contains {amountOfLetters} letters and {amountOfPunctuations} punctuation marks.");
            }

            void Sort(string text)
            {
                
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var sortText = wordsOfText.OrderByDescending(s => s.Length);
                Console.WriteLine("String after sorting:");
                Console.WriteLine();
                Console.WriteLine(String.Join(" ", sortText));
            }

            string text = "один, два, три, четыре, пять, шесть, восемь, девять, десять.";

            Console.WriteLine("Source string:");
            Console.WriteLine();
            Console.WriteLine(text);

            Console.WriteLine();
            DeleteLongestWord(text);

            Console.WriteLine();
            SwapWords(text);

            Console.WriteLine();
            CountChar(text);

            Console.WriteLine();
            Sort(text);
        }
    }
}