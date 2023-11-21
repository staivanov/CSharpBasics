using System;

namespace Methos
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivan";
            PrintName(name);
        }
        public static void PrintName(string name)
        {
            string greeting = $"Hello {name}!";
            Console.WriteLine(greeting);
        }
    }
}
