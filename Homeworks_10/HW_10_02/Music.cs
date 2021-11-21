namespace HW_10_02
{
    class Music : File
    {
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
            return $"Song: \n ID in the store: {id}.\n Name: {Name}. \n Category of music: {Category}. \n Singer: {Singer}. \n Length of composition {Length} seconds. \n  File size: {Size} MB. \n";
        }
        public override string ToString()
        {
            return Play();
        }
    }
}