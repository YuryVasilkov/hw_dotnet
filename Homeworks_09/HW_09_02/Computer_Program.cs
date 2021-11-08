using System;

namespace HW_09_02
{
    class ComputerProgram
    {
        private Guid _id = Guid.NewGuid();

        public string Name { get; set; }
        public int Size { get; set; }
        public string Category { get; set; }

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

        public override string ToString()
        {
            return $" ID in the store: {_id}. \n Name: {Name}. \n Category of the file: {Category}. \n File size: {Size} MB. \n";
        }
    }
}