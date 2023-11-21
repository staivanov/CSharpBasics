using System;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timeHoursForOneProject = 3;
            int projectHours = numberOfProjects * timeHoursForOneProject;

            Console.WriteLine($"The architect {architectName} will need {projectHours} hours to complete {numberOfProjects} project / s.");
        }
    }
}
