using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_10_03
{
    class Engineer
    {
        public const string company = "Funny .net programmers";
        public const int defaultSalary = 500;

        public readonly Guid id = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string GitHub { get; set; }
        public virtual List<string> Responsibilities { get; set; }
        public virtual List<string> Technologies { get; set; }

        public Engineer()
        {
            Responsibilities = new();
            Technologies = new();
            Responsibilities.Add("Knowledge of English");
            Responsibilities.Add("Knowledge of OOP");
            Technologies.Add("c#");
            Technologies.Add("LINQ");
            Technologies.Add(".NET framework");
            Technologies.Add("Git");
        }
        public Engineer(string firstName, string lastName, int experience, string gitHub)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            GitHub = gitHub;
        }

        public virtual int GetSalary()
        {
            return defaultSalary;
        }
        public override string ToString()
        {
            string title = GetType().ToString().Split(".").Last();
            string res = $"Company: {company}\nFull name: {FirstName} {LastName}\nExperience: {Experience} years.\nTitle: {title}\nSalary: {GetSalary() } dollars\nGitHub: {GitHub}";
            return res;
        }
    }
}