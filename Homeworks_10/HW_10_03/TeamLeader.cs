using System.Collections.Generic;

namespace HW_10_03
{
    class TeamLeader : Engineer
    {
        public override List<string> Responsibilities { get; set; }
        public override List<string> Technologies { get; set; }

        public TeamLeader()
        {
            Responsibilities.Add("Analysis of requirements and assessment of labor costs");
            Responsibilities.Add("Management of a group of developers up to 5 people");
            Responsibilities.Add("Transfer of projects to the customer");
        }
        public TeamLeader(string firstName, string lastName, int experience, string gitHub)
            : base(firstName, lastName, experience, gitHub)
        {

        }

        public override int GetSalary()
        {
            return 500 * 8 + 500;
        }
    }
}