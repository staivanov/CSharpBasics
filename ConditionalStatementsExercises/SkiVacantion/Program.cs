using System;

namespace SkiVacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDay = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double totalPrice = 1,
                onePersonRoomPrice = 18,
                apartmentRoomPrice = 25,
                presidenApartmentRoomPrice = 35,
                possitiveFeedbackDiscount = 0.25,
                negativeFeedbackDiscount = 0.1,
                feedbackDiscount = 0,
                vacationDiscount = 0,
                regularVacationPrice = 0;

            bool isNightsBelow10Days = vacationDay < 10;
            bool isNightsBetween10And15Days = vacationDay >= 10 && vacationDay <= 15;
            bool isNightsAbove15Days = vacationDay > 15;

            string onePersonRoom = "room for one person",
                apartment = "apartment",
                presidentApartment = "president apartment",
                possitiveFeedback = "positive";

            feedbackDiscount = feedback == possitiveFeedback ? possitiveFeedbackDiscount : negativeFeedbackDiscount;


            if (roomType == onePersonRoom  && (isNightsBelow10Days || isNightsBetween10And15Days || isNightsAbove15Days))
            {
                totalPrice = vacationDay * onePersonRoomPrice;
                totalPrice = totalPrice + (totalPrice * feedbackDiscount);
            }
            else if (roomType == apartment)
            {
                regularVacationPrice = vacationDay * apartmentRoomPrice;

                if (isNightsBelow10Days)
                {
                    vacationDiscount = 0.3;
                    totalPrice = regularVacationPrice - (totalPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
                else if (isNightsBetween10And15Days)
                {
                    vacationDiscount = 0.35;
                    totalPrice = regularVacationPrice - (regularVacationPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
                else if (isNightsAbove15Days)
                {
                    vacationDiscount = 0.5;
                    totalPrice = regularVacationPrice - (totalPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
            }
            else if (roomType == presidentApartment)
            {
                regularVacationPrice = vacationDay * presidenApartmentRoomPrice;

                if (isNightsBelow10Days)
                {
                    vacationDiscount = 0.1;
                    totalPrice = regularVacationPrice - (totalPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
                else if (isNightsBetween10And15Days)
                {
                    vacationDiscount = 0.15;
                    totalPrice = regularVacationPrice - (regularVacationPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
                else if (isNightsAbove15Days)
                {
                    vacationDiscount = 0.2;            
                    totalPrice = regularVacationPrice - (totalPrice * vacationDiscount);
                    totalPrice = totalPrice + totalPrice * feedbackDiscount;
                }
            }

                Console.WriteLine(totalPrice);
        }
    }
}
