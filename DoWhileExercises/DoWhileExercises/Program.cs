using System;

namespace DoWhileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopCommand = "Stop";
            string userWord = "";

            while(true)
            {
                userWord = Console.ReadLine();

                if(userWord == stopCommand)
                {
                    break;
                }

                Console.WriteLine(userWord);
            }
        }
    }
}
