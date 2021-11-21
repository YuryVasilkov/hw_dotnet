namespace HW_10_02
{
    class ComputerProgram :File
    {
        public int Size { get; set; }

        public ComputerProgram()
        {
            Name = string.Empty;
            Size = 0;
            Category = string.Empty;
        }
        public ComputerProgram(string name, string category, int size)
        {
            Name = name;
            Category = category;
            Size = size;
        }

        public string Play()
        {
            return $"Program: \n ID in the store: {id}. \n Name: {Name}. \n Category of the file: {Category}. \n File size: {Size} MB. \n";
        }
        public override string ToString()
        {
            return Play();
        }
    }
}