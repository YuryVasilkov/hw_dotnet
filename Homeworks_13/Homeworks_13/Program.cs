using System;
using Newtonsoft.Json;

namespace HW_13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            static dynamic GetSongData(Song song)
            {
                return new { song.Title, song.Minutes, song.AlbumYear, song.Genre };
            }
            static void GetJsonWithTextJson(dynamic info)
            {
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(info));
            }

            Song song1 = new("Fur Elise", 4, "Beethoven", 1810);
            song1.SetGenre("Classical");

            var info = GetSongData(song1);
            Console.WriteLine(info);

            Console.WriteLine(new string('*', 50));
            Console.WriteLine(JsonConvert.SerializeObject(info));

            Console.WriteLine(new string('*', 50));
            GetJsonWithTextJson(info);
        }
    }
}