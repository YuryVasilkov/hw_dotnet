using System;
using System.Collections;

namespace HW_10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection = new();
            collection.Add(new Music("Love Tonight", "Dance", "Shouse", 242, 5));
            collection.Add(new Music("Love Tonight", "Dance", "Shouse", 242, 5));
            collection.Add(new Music("Easy on me", "POP", "Adele", 225, 10));
            collection.Add(new Music("Redemption", "Acoustics", "Hurts", 258, 6));
            collection.Add(new Film("Deadpool", "comedy fantasy action", "Tim Miller", "Ryan Rodney Reynolds", "Brianna Caitlin Hildebrand", 10_000));
            collection.Add(new Film("Движение вверх", "Спортивная драма", "Антон Мегердичев", "Владимир Машков", "Виктория Толстоганова", 5_625));
            collection.Add(new Film("Ледяной демон", "Ужасы", "Иван Капитонов", "Алексей Розин", "Ольга Ломоносова", 7_677));
            collection.Add(new ComputerProgram("Microsoft Office", "Desktop application", 999));
            collection.Add(new ComputerProgram("AIMP", "Music player", 86));
            collection.Add(new ComputerProgram("PotPlayer", "Video player", 245));
            collection.Add(new ComputerProgram("Adobe photoshop", "Work with images", 7999));

            Console.WriteLine("Our catalog:");
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i].ToString());
            }
        }
    }
}