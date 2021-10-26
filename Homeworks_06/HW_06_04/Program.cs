using System;
using System.Collections.Generic;
using System.IO;

namespace HW_06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            const char findSymbol = '\u001f';
            List<int> positions = new();
            StreamReader textReader = new(@"C:\Temp\FindMe.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();

            for (int i = 0; i < textReaderResult.Length; i++)
            {
                if (textReaderResult[i] == findSymbol)
                {
                    count++;
                    positions.Add(i);
                }
            }

            if (count != 0)
            {
                Console.WriteLine($"{count} symbols were found in the text.");
                Console.WriteLine();
                Console.WriteLine($"Decimal code: {(int)findSymbol}");
                Console.WriteLine();
                Console.WriteLine("Positions in text:");
                foreach (var item in positions)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Symbol wasn't found.");
            }
        }
    }
}
