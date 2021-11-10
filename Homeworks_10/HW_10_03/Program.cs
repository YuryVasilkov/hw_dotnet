using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_10_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engineer> employees = new();
            employees.Add(new Architect("Vadzim", "Papko", 7, "https://github.com/VadzimPapko"));
            employees.Add(new JuniorDeveloper("Yury", "Vasilkov", 0, "https://github.com/YuryVasilkov"));
            employees.Add(new TeamLeader("Maria", "Levchenkova", 4, "https://github.com/MariaLevchenkova"));
            employees.Add(new TeamLeader("Yulia", "Rodioshkina", 5, "https://github.com/YuliaRodioshkina"));
            employees.Add(new SeniorDeveloper("Anastasia", "Fedorovich", 3, "https://github.com/AnastasiaFedorovich"));
            employees.Add(new SeniorDeveloper("Darya", "Norko", 4, "https://github.com/DaryaNorko"));
            employees.Add(new MiddleDeveloper("Maksim", "Nozdrin-Plotnitski", 2, "https://github.com/maksimnp"));
            employees.Add(new MiddleDeveloper("Igor", "Parfenec", 2, "https://github.com/IgorParfenec"));
            employees.Add(new MiddleDeveloper("Vladislav", "Klimovich", 1, "https://github.com/VladislavKlimovich"));
            employees.Add(new MiddleDeveloper("Vladimir", "Koshuba", 1, "https://github.com/VladimirKoshuba"));
            employees.Add(new SeniorDeveloper("Andrey", "Sinenok", 4, "https://github.com/AndreySinenok"));
            employees.Add(new MiddleDeveloper("Ivan", "Sichkar", 2, "https://github.com/IvanSichkar"));
            employees.Add(new JuniorDeveloper("No", "Name", 0, "https://github.com/no_name"));

            var results = employees.OrderBy(x => x.Experience).ToList();
            for (int i = results.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(results[i].ToString());
                Console.WriteLine();
            }
        }
    }
}