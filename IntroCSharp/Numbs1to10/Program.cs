using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeA = int.Parse(Console.ReadLine());
            int sizeB = int.Parse(Console.ReadLine());
            int triangleArea = sizeA * sizeB;
            Console.WriteLine(triangleArea);
        }
    }
}
