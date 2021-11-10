using System.Collections.Generic;

namespace HW_10_03
{
    class SeniorDeveloper : Engineer
    {
        public override List<string> Responsibilities { get; set; }
        public override List<string> Technologies { get; set; }

        public SeniorDeveloper()
        {
            Responsibilities.Add("Design and development of software applications");
            Responsibilities.Add("Analysis of requirements, collaboration with team members to create thoughtful software projects.");
            Responsibilities.Add("Simplify the development process to provide high quality software solutions.");
            Technologies.Add("Frameworks");
        }
        public SeniorDeveloper(string firstName, string lastName, int experience, string gitHub)
            : base(firstName, lastName, experience, gitHub)
        {

        }

        public override int GetSalary()
        {
            return 500 * 5 + 300;
        }
    }
}