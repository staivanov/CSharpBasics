using System;

namespace _8._BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearPaymentTax = double.Parse(Console.ReadLine());
            double sneakersPrice = yearPaymentTax - (yearPaymentTax * 0.4);
            double basketballKit = sneakersPrice - (sneakersPrice * 0.2);
            double ball = basketballKit / 4;
            double basketballAccessories = ball / 5;
            Console.WriteLine(sneakersPrice + basketballKit + ball + basketballAccessories + yearPaymentTax);
        }
    }
}
