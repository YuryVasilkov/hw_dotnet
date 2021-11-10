using System.Collections.Generic;

namespace HW_10_03
{
    class JuniorDeveloper:Engineer
    {
        public override List<string> Responsibilities { get; set; }
        public override List<string> Technologies { get; set; }

        public JuniorDeveloper()
        {
            Responsibilities.Add("Perform testing");
            Responsibilities.Add("Code check");
            Responsibilities.Add("Development of documentation"); 
        }
        public JuniorDeveloper(string firstName, string lastName, int experience, string gitHub)
            : base(firstName, lastName, experience, gitHub)
        {

        }
    }
}