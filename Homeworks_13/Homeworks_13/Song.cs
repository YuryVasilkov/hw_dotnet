using System;

namespace HW_13_01
{
    class Song
    {
        public enum Genres
        {
            None = 0,
            Classical = 1,
            Jazz = 2,
            Rap = 4,
            Electronic = 8,
            Rock = 16,
            Disco = 32,
            Pop = 64,
        }

        public string Title { get; }
        public int Minutes { get; }
        public string Author { get; }
        public int AlbumYear { get; }

        private Enum _genre;

        public Enum Genre
        {
            get { return _genre; }
        }

        public Song(string title, int minutes, string author, int albumYear)
        {
            Title = title;
            Minutes = minutes;
            Author = author;
            AlbumYear = albumYear;
        }

        public void SetGenre(int num)
        {
            _genre = (Enum)Enum.ToObject(typeof(Genres), num);
            if (!Enum.IsDefined(typeof(Genres), _genre)) _genre = Genres.None;
        }
        public void SetGenre(string num)
        {
            if (Enum.IsDefined(typeof(Genres), num)) _genre = (Genres)Enum.Parse(typeof(Genres), num, true);
            else _genre = Genres.None;
        }
    }
}