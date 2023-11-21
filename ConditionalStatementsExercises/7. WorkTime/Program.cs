using System;

namespace WorkTime
{
    class Program
    {
        static void Main(string[] args)
        {

            int userTime = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            int officeOpen = 10;
            int officeClose = 18;
            bool isOfficeOpen = userTime >= officeOpen &&  userTime <= officeClose;
            string dayOff = "Sunday";

            if(isOfficeOpen && (dayOff != day))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("close");
            }

        }
    }
}
