using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_08_03
{
    class Program
    {
        static void Main(string[] args)
        {
            void Travel(string list, string searchCode)
            {
                Regex regex = new(@"[A-Z\s]{3}\d{5}");
                MatchCollection match = regex.Matches(list);

                if (match.Count != 0)
                {
                    string[] adresses = list.Split(',');
                    StringBuilder sb = new();
                    List<int> hitIndexes = new();

                    for (int i = 0; i < match.Count; i++)
                    {
                        if (searchCode.Equals(match[i].ToString()))
                        {
                            hitIndexes.Add(i);
                        }
                    }

                    if (hitIndexes.Count == 0)
                    {
                        Console.WriteLine(searchCode + ":/");
                    }
                    else if (hitIndexes.Count == 1)
                    {
                        int positionOfFirstLetter = 0;
                        for (int j = 0; j < adresses[hitIndexes[0]].Length; j++)
                        {
                            if (char.IsLetter(adresses[hitIndexes[0]][j]))
                            {
                                positionOfFirstLetter = j;
                                break;
                            }
                        }

                        sb.Append(match[hitIndexes[0]] + ":/ ");
                        sb.Append(adresses[hitIndexes[0]].Substring(positionOfFirstLetter, adresses[hitIndexes[0]].Length - match[hitIndexes[0]].Length - positionOfFirstLetter - 1));
                        sb.Append("/" + adresses[hitIndexes[0]].Substring(0, positionOfFirstLetter));

                        Console.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                    else if (hitIndexes.Count > 1)
                    {
                        int[] positionsOfFirstLetter = new int[hitIndexes.Count];

                        sb.Append(match[hitIndexes[0]] + ":/ ");
                        for (int i = 0; i < hitIndexes.Count; i++)
                        {
                            for (int j = 0; j < adresses[hitIndexes[i]].Length; j++)
                            {
                                if (char.IsLetter(adresses[hitIndexes[i]][j]))
                                {
                                    positionsOfFirstLetter[i] = j;
                                    break;
                                }
                            }
                            sb.Append(adresses[hitIndexes[i]].Substring(positionsOfFirstLetter[i], adresses[hitIndexes[i]].Length - match[hitIndexes[i]].Length - 1 - positionsOfFirstLetter[i]) + ", ");
                        }

                        sb.Remove(sb.Length - 2, 2);
                        sb.Append('/');

                        for (int i = 0; i < hitIndexes.Count; i++)
                        {
                            sb.Append(adresses[hitIndexes[i]].Substring(0, (positionsOfFirstLetter[i]) - 1) + ",");
                        }

                        sb.Remove(sb.Length - 1, 1);
                        Console.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                }
            }

            const string list = "123 Main Street St.Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";

            Console.WriteLine("Please, input ZIP code.");
            string searchCode = Console.ReadLine().ToUpper();
            Console.Clear();
            Travel(list, searchCode);
        }
    }
}