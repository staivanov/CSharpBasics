using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopCommand = "Enough";
            int badGradeMax = 4,
                exerciseCounter = 0,
                badGradeCounter = 0;

            int badGradesNumber = int.Parse(Console.ReadLine());
            string exerciseName = " ",
                lastExercises = " ";
            int grade = 0,
            gradeSum = 0;
            double averageScore = 0;

            while (true)
            {
                exerciseName = Console.ReadLine();

                if (exerciseName == stopCommand)
                {
                    averageScore = (double)gradeSum / exerciseCounter;

                    Console.WriteLine($"Average score: {averageScore:F2}");
                    Console.WriteLine($"Number of problems: {exerciseCounter}");
                    Console.WriteLine($"Last problem: {lastExercises}");
                    break;
                }

                lastExercises = exerciseName;

                grade = int.Parse(Console.ReadLine());

                if (badGradeMax <= grade)
                {
                    badGradesNumber--;
                    badGradeCounter++;

                }
                else if (badGradesNumber == 0)
                {
                    Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
                }

                gradeSum += grade;
                exerciseCounter++;
            }

        }
    }
}
