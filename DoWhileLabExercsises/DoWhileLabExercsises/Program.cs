using System;

namespace DoWhileLabExercsises
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string nextBook = Console.ReadLine();
            string stopSearchingCommand = "No More Books";
            int bookCounter = 0;
            bool isBookFound = false;

            while (nextBook != stopSearchingCommand)
            {
                if (nextBook == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }

                bookCounter++;
                nextBook = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
