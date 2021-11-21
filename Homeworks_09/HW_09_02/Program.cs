using System;

namespace HW_09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Music[] arrOfMusic = new Music[50];
            Film[] arrOfFilms = new Film[50];
            ComputerProgram[] arrOfPrograms = new ComputerProgram[50];

            arrOfMusic[0] = new("Love Tonight", "Dance", "Shouse", 242, 5);
            arrOfMusic[1] = new("Easy on me", "POP", "Adele", 225, 10);
            arrOfMusic[2] = new("Redemption", "Acoustics", "Hurts", 258, 6);

            arrOfFilms[0] = new("Deadpool", "comedy fantasy action", "Tim Miller", "Ryan Rodney Reynolds", "Brianna Caitlin Hildebrand", 10_000);
            arrOfFilms[1] = new("Движение вверх", "Спортивная драма", "Антон Мегердичев", "Владимир Машков", "Виктория Толстоганова", 5_625);
            arrOfFilms[2] = new("Ледяной демон", "Ужасы", "Иван Капитонов", "Алексей Розин", "Ольга Ломоносова", 7_677);

            arrOfPrograms[0] = new("Microsoft Office", "Desktop application", 999);
            arrOfPrograms[1] = new("AIMP", "Music player", 86);
            arrOfPrograms[2] = new("PotPlayer", "Video player", 245);
            arrOfPrograms[3] = new("Adobe photoshop", "Work with images", 7999);

            Console.WriteLine("Our catalog:");
            Console.WriteLine("Music:");

            foreach (var item in arrOfMusic)
            {
                if (item is null)
                    break;
                else
                    Console.WriteLine(item.Play());
            }

            Console.WriteLine(new string('*', 100));
            Console.WriteLine("Films:");

            foreach (var item in arrOfFilms)
            {
                if (item is null)
                    break;
                else
                    Console.WriteLine(item.Play());
            }

            Console.WriteLine(new string('*', 100));
            Console.WriteLine("Computer programs:");

            foreach (var item in arrOfPrograms)
            {
                if (item is null)
                    break;
                else
                    Console.WriteLine(item.ToString());
            }
        }
    }
}