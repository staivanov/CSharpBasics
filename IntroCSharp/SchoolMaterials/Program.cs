using System;

namespace SchoolMaterials
{
    class Program
    {
        static void Main(string[] args)
        {

            double penPackage = 5.8,
                markerPackage = 7.2,
                abstergentPerLiter = 1.2,
                discountPercent = 0,
                totalPriceWithoutDiscount = 0,
                finalPrice = 0;

            double penPackageNumer = double.Parse(Console.ReadLine());
            double markerPackageNumber = double.Parse(Console.ReadLine());
            double abstergentLiters = double.Parse(Console.ReadLine());
            discountPercent = double.Parse(Console.ReadLine());

            totalPriceWithoutDiscount = (penPackageNumer * penPackage) +
                (markerPackage * markerPackageNumber) +
                (abstergentPerLiter * abstergentLiters);

            finalPrice = totalPriceWithoutDiscount - (totalPriceWithoutDiscount * (discountPercent / 100));
            Console.WriteLine(finalPrice);

        }
    }
}
