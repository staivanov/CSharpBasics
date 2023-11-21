using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            const string banana = "banana",
               apple = "apple",
               kiwi = "kiwi",
               lemon = "lemon",
               grapes = "grapes",
               cherry = "cherry";

            const string tomato = "tomato",
              cucumber = "cucumber",
              pepper = "pepper",
              carrot = "carrot";

            switch (userInput)
            {
                case banana:
                case apple:
                case kiwi:
                case lemon:
                case grapes:
                case cherry:
                    Console.WriteLine("fruit");
                    break;
                case tomato:
                case cucumber:
                case pepper:
                case carrot:
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknow");
                    break;
            }
        }
    }
}