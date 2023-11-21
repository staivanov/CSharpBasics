using System;

namespace GraduationAverageRecords
{
    class Program
    {
        static void Main(string[] args)
        {

            string studetName = Console.ReadLine();
            double minYearSuccessGrade = 4,
                gradeBrokeCounter = 0,
                yearToGraduation = 12,
                currentYear = 0,
                gradesSum = 0,
                yearGrade;    

            while(currentYear <= yearToGraduation)
            {
                yearGrade = double.Parse(Console.ReadLine());

                
                if(yearGrade < minYearSuccessGrade)
                {
                    gradeBrokeCounter++;

                    if(gradeBrokeCounter == 2)
                    {
                        Console.WriteLine($"{studetName} has been excluded at {currentYear}");
                        break;
                    }
                }

                gradesSum = currentYear + gradesSum;

                currentYear++;

                if(currentYear == yearToGraduation)
                {
                    double averageYearGrade = gradesSum / yearToGraduation;
                    Console.WriteLine($"{studetName} graduated. Average grade: {averageYearGrade}");
                    break;
                }

            }


        }
    }
}
