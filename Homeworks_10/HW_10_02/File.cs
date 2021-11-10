using System;

namespace HW_10_02
{
    class File
    {
        public readonly Guid id = Guid.NewGuid();
        public string Name { get; set; }
        public string Category { get; set; }
    }
}