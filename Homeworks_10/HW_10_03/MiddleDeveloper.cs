using System.Collections.Generic;

namespace HW_10_03
{
    class MiddleDeveloper:Engineer
    {
        public override List<string> Responsibilities { get; set; }
        public override List<string> Technologies { get; set; }

        public MiddleDeveloper()
        {
            Responsibilities.Add("Knowledge and application of design patterns");
            Responsibilities.Add("Creating and storing SQL procedures.");
            Responsibilities.Add("Creating and maintaining existing API modules.");
            Technologies.Add("SQL");
            Technologies.Add("Design patterns");
            Technologies.Add("Basic Front-End");
        }
        public MiddleDeveloper(string firstName, string lastName, int experience, string gitHub)
            : base(firstName, lastName, experience, gitHub)
        {

        }

        public override int GetSalary()
        {
            return defaultSalary * 3;
        }
    }
}