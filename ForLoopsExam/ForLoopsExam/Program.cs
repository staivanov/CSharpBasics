using System;

namespace ForLoopsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int userNumber;

            int below200Counter = 0,
                between200to399Counter = 0,
                between400to599Counter = 0,
                between600to799Counter = 0,
                aboveOrEqual800Counter = 0;

            double p1 = 0,
            p2 = 0,
            p3 = 0,
            p4 = 0,
            p5 = 0;

            for (int i = 0; i < n; i++)
            {

                userNumber = int.Parse(Console.ReadLine());

                bool isBelow200 = userNumber < 200,
                      isBetween200to399 = userNumber >= 200 && userNumber <= 399,
                      isBetween400to599 = userNumber >= 400 && userNumber <= 599,
                      isBetween600to799Counter = userNumber >= 600 && userNumber <= 799,
                      isAboveOrEqual800 = userNumber >= 800;

                if (isBelow200)
                {
                    below200Counter++;
                }
                else if (isBetween200to399)
                {

                    between200to399Counter++;
                }
                else if (isBetween400to599)
                {

                    between400to599Counter++;
                }
                else if (isBetween600to799Counter)
                {

                    between600to799Counter++;
                }
                else if (isAboveOrEqual800)
                {

                    aboveOrEqual800Counter++;
                }
            }

            p1 = (double)below200Counter / (double)n * 100;
            p2 = (double)between200to399Counter / (double)n * 100;
            p3 = (double)between400to599Counter / (double)n * 100;
            p4 = (double)between600to799Counter / (double)n * 100;
            p5 = (double)aboveOrEqual800Counter / (double)n * 100;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"{p1:F2}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{p2:F2}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{p3:F2}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{p4:F2}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{p5:F2}");
        }
    }
}
