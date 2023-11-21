using System;

namespace Paycheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabsNumber = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string websiteName,
                facebook = "Facebook",
                instagram = "Instagram",
                reddit = "Reddit";

            int facebookPenalty = 150,
                instagramPentaly = 100,
                redditPenalty = 50;

            for (int i = 0; i < openTabsNumber; i++)
            {
                websiteName = Console.ReadLine();

                if (facebook == websiteName)
                {
                    salary = salary - facebookPenalty;
                    SalaryNegativeCheck(salary);
                }
                else if (instagram == websiteName)
                {
                    salary = salary - instagramPentaly;
                    SalaryNegativeCheck(salary);
                }
                else if (reddit == websiteName)
                {
                    salary = salary - redditPenalty;
                    SalaryNegativeCheck(salary);
                }
            }

            Console.WriteLine(salary);

        }

        public static void SalaryNegativeCheck(int salary)
        {

            bool isSalaryPositive = salary > 0 ? true : false;

            if (!isSalaryPositive)
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
