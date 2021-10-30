using System;
using System.Text;

namespace HW_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string text = "1a!2.3!!.. 4.!.?6 7! ..?";
            StringBuilder sb = new();
            int index = text.IndexOf('?');
            if (index != -1)
            {
                sb.Append(text.Substring(0, index).Replace("!", string.Empty).Replace(".", string.Empty));
                sb.Append(text.Substring(++index, text.Length - index).Replace(" ", "_"));
                Console.WriteLine("Result string:");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("String doesn't contain character '?' ");
            }
        }
    }
}