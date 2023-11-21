using System;

namespace Buildings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOneFloorBuilding;
            char apartmentSymbol = 'A',
                officeSymbol = 'O',
                LastFloorApartment = 'L';

            int floorsNumber = int.Parse(Console.ReadLine());
            int roomsNumber = int.Parse(Console.ReadLine());

            for (int floor = floorsNumber; floor > 0; floor--)
            {

                for (int room = 0; room < roomsNumber; room++)
                {
                    isOneFloorBuilding = floor == floorsNumber ? true : false;
                    bool isEvenBelowLastFloor = (floorsNumber - 1) % 2 == 0 ? true : false;

                    if (isOneFloorBuilding || floorsNumber == floor)
                    {
                        Console.Write($"{LastFloorApartment}{floor}{room} ");
                    }
                    else if (isEvenBelowLastFloor)
                    {
                        Console.Write($"{officeSymbol}{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"{apartmentSymbol}{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
