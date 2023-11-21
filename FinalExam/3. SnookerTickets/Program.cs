using static System.Console;

namespace SnookerTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketStage = ReadLine();
            string ticketType = ReadLine();
            int ticketNumber = int.Parse(ReadLine());
            char trophyPicture = char.Parse(ReadLine());

            double currentCheck = 0,
             trophyPicturePrice = 40,
                 currenentTicketPrice = 0;

            string quarterFinal = "Quarter final",
                semiFinal = "Semi final",
                final = "Final";

            const string STANDARD = "Standard",
                 PREMIUM = "Premium",
                 VIP = "VIP";


            if (ticketStage == quarterFinal)
            {
                switch (ticketType)
                {
                    case STANDARD:
                        currenentTicketPrice = 55.5;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case PREMIUM:
                        currenentTicketPrice = 55.5;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case VIP:
                        currenentTicketPrice = 55.5;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                }
            }
            else if (ticketStage == semiFinal)
            {
                switch (ticketType)
                {
                    case STANDARD:
                        currenentTicketPrice = 75.88;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case PREMIUM:
                        currenentTicketPrice = 125.222;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case VIP:
                        currenentTicketPrice = 300.4;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                }
            }
            else if (ticketStage == final)
            {
                switch (ticketType)
                {
                    case STANDARD:
                        currenentTicketPrice = 110.1;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case PREMIUM:
                        currenentTicketPrice = 160.66;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                    case VIP:
                        currenentTicketPrice = 400;
                        currentCheck = GetCurrentCheck(currenentTicketPrice, ticketNumber); break;
                }
            }


            double specialOffer = 4000;
            double offer = 2500;
            bool isValueOver4k = currentCheck > specialOffer ? true : false;
            bool isValueOver2k = currentCheck > offer && currentCheck < specialOffer ? true : false;
            bool isTrophyPictureIncluded = trophyPicture == 'Y';
            double finalCheck = 0;

            //Below 2500 pounds.
            if (!isValueOver2k && isTrophyPictureIncluded)
            {
                finalCheck = currentCheck + trophyPicturePrice * ticketNumber;
                WriteLine(finalCheck);
            }
            else if (!isValueOver2k && !isTrophyPictureIncluded)
            {
                WriteLine(currentCheck);
            }

            //Over 2500 pounds and below 4000 pounds.
            if (isValueOver2k && isTrophyPictureIncluded)
            {
                finalCheck = currentCheck - (currentCheck * 0.1) + (trophyPicturePrice * ticketNumber);
                WriteLine(finalCheck);
            }
            else if (isValueOver2k && !isTrophyPictureIncluded)
            {
                finalCheck = currentCheck - (currentCheck * 0.1);
                WriteLine(finalCheck);
            }

            //Over 4000 pounds.
            if (isValueOver4k)
            {
                finalCheck = currentCheck - (currentCheck * 0.25);
            }
        }

        public static double GetCurrentCheck(double ticketPrice, double ticketNumber)
        {
            double total = ticketPrice * ticketNumber;
            return total;
        }
    }
}
