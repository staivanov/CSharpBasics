using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double remainder = double.Parse(Console.ReadLine());
            double stotinki = remainder * 100;
            int coinCounter = 0;

            while (stotinki > 0)
            {
                if (stotinki >= 200)
                {
                    coinCounter++;
                    stotinki -= 200;
                }
                else if (stotinki >= 100)
                {
                    coinCounter++;
                    stotinki -= 100;
                }
                else if (stotinki >= 50)
                {
                    coinCounter++;
                    stotinki -= 50;
                }
                else if (stotinki >= 20)
                {
                    coinCounter++;
                    stotinki -= 20;
                }
                else if (stotinki >= 10)
                {
                    coinCounter++;
                    stotinki -= 10;
                }
                else if (stotinki >= 5)
                {
                    coinCounter++;
                    stotinki -= 5;
                }
                else if (stotinki >= 2)
                {
                    coinCounter++;
                    stotinki -= 2;
                }
                else if (stotinki >= 1)
                {
                    coinCounter++;
                    stotinki -= 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(coinCounter);
        }
    }
}
