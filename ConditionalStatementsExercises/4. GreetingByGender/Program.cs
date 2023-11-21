using System;

namespace _4._GreetingByGender
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            int mrAge = 16,
                masterAge = 15,
                msAge = 16,
                missAge = 15;

            string male = "male",
                female = "female";

            bool isMale = gender == male,
                isFemale = gender == female;

            if(age <= masterAge && isMale)
            {
                Console.WriteLine("Master");
            }
            else if(age >= mrAge && isMale)
            {
                Console.WriteLine("Mr.");
            }
            else if(age <= missAge && isFemale)
            {
                Console.WriteLine("Miss");
            }
            else if(age >= msAge && isFemale)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
