using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double fullnessPercent = double.Parse(Console.ReadLine());

  
            double oneLiterWaterToCubicDecimeter = 1,
                fullnessCapacity = fullnessPercent / 100;
          
            double aquariumCapacity = length * width * height;
            double aquariumVolumeLitters = aquariumCapacity / 1000;
            double aquariumLitters = aquariumVolumeLitters * (oneLiterWaterToCubicDecimeter - fullnessCapacity);
            Console.WriteLine(aquariumLitters);

        }
    }
}
