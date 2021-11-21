using System;
using System.Collections.Generic;

namespace HW_10_03
{
    class Architect : Engineer
    {
        public override List<string> Responsibilities { get; set; }
        public override List<string> Technologies { get; set; }

        public Architect()
        {
            Responsibilities.Add("Understanding the client's business, the ability to analyze complex technical systems and then convey this understanding to the customer and developers.");
            Responsibilities.Add("Broad outlook in terms of platforms and components availbale on the market from which a solution can be synthsised.");
            Technologies.Add("Architectural guides");
        }
        public Architect(string firstName, string lastName, int experience, string gitHub)
            : base(firstName, lastName, experience, gitHub)
        {

        }

        public override int GetSalary()
        {
            return 12* defaultSalary + 1000;
        }
    }
}