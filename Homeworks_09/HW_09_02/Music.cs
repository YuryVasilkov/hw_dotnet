using System;

namespace HW_09_02
{
    class Music
    {
        private Guid _id = Guid.NewGuid();

        public string Name { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public string Singer { get; set; }
        public int Length { get; set; }

        public Music()
        {
            Name = string.Empty;
            Category = string.Empty;
            Size = 0;
            Singer = string.Empty;
            Length = 0;
        }
        public Music(string name, string category, string singer, int length, int size)
        {
            Name = name;
            Category = category;
            Singer = singer;
            Length = length;
            Size = size;
        }

        public string Play()
        {
            return $" ID in the store: {_id}.\n Name: {Name}. \n Category of music: {Category}. \n Singer: {Singer}. \n Length of composition {Length} seconds. \n  File size: {Size} MB. \n";
        }
    }
}