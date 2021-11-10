namespace HW_10_02
{
    class Film : File
    {
        public int Size { get; set; }
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }

        public Film()
        {
            Name = string.Empty;
            Size = 0;
            Category = string.Empty;
            Director = string.Empty;
            MainActor = string.Empty;
            MainActress = string.Empty;

        }
        public Film(string name, string category, string director, string mainActor, string mainActress, int size)
        {
            Name = name;
            Category = category;
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
            Size = size;
        }

        public string Play()
        {
            return $" Film: \n ID in the store: {id}. \n Name: {Name}. \n Category of the film: {Category}. \n Director: {Director}. \n Main actor: {MainActor}. \n Main actress: {MainActress}. \n File size: {Size} MB. \n";
        }
        public override string ToString()
        {
            return Play();
        }
    }
}