using System;

namespace HW_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            void DeleteLongestWord(string text)
            {
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string longestWord = wordsOfText[0];

                for (int i = 1; i < wordsOfText.Length; i++)
                {
                    if (longestWord.Length < wordsOfText[i].Length)
                    {
                        longestWord = wordsOfText[i];
                    }
                }

                Console.WriteLine("Text after deletion:");
                Console.WriteLine();
                Console.WriteLine(text.Replace(longestWord,""));
            }

            void SwapWords (string text)
            {
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string longestWord = wordsOfText[0];
                string shortestWord = wordsOfText[0];
                int indexOfMax = 0;
                int indexOfMin = 0;

                for (int i = 1; i < wordsOfText.Length; i++)
                {
                    if (longestWord.Length < wordsOfText[i].Length)
                    {
                        longestWord = wordsOfText[i];
                        indexOfMax = i;
                    }

                    if (shortestWord.Length > wordsOfText[i].Length)
                    {
                        shortestWord = wordsOfText[i];
                        indexOfMin = i;
                    }
                }

                wordsOfText[indexOfMin] = longestWord;
                wordsOfText[indexOfMax] = shortestWord;
                Console.WriteLine("Text after swapping:");
                Console.WriteLine();
                Console.WriteLine(String.Join(" ", wordsOfText));
            }

            void CountChar(string text)
            {
                int amountOfLetters = 0;
                int amountOfPunctuations = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLetter(text[i]))
                    {
                        amountOfLetters++;
                    }

                    if (char.IsPunctuation(text[i]))
                    {
                        amountOfPunctuations++;
                    }
                }

                Console.WriteLine($"String contains {amountOfLetters} letters and {amountOfPunctuations} punctuation marks.");
            }

            void Sort (string text)
            {
                string[] wordsOfText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string temp;

                for (int i = 1; i < wordsOfText.Length; i++)
                {
                    for (int j = 0; j < wordsOfText.Length - i; j++)
                    {
                        if (wordsOfText[j].Length < wordsOfText[j + 1].Length)
                        {
                            temp = wordsOfText[j];
                            wordsOfText[j] = wordsOfText[j + 1];
                            wordsOfText[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("String after sorting:");
                Console.WriteLine();
                Console.WriteLine(String.Join(" ", wordsOfText));
            }

            string text = "Современные технологии достигли такого уровня, что укрепление и развитие внутренней структуры однозначно определяет каждого участника как способного принимать собственные решения касаемо направлений прогрессивного развития. Следует отметить, что понимание сути ресурсосберегающих технологий не оставляет шанса для новых принципов формирования материально-технической и кадровой базы.";
            
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
