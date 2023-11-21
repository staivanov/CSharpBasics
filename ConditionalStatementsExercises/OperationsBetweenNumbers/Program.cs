using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char mathematicOperator = char.Parse(Console.ReadLine());

            string evenOrOdd = " ";
            double result = 0;

            bool isNumbTwoZero = numberTwo == 0;

            if ((mathematicOperator == '/' && isNumbTwoZero) || (mathematicOperator == '%' && isNumbTwoZero))
            {
                Console.WriteLine($"Cannot divide {numberOne} by zero");
            }

            switch (mathematicOperator)
            {
                case '+':
                    result = numberOne + numberTwo;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - {evenOrOdd}");
                    break;

                case '-':
                    result = numberOne - numberTwo;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - {evenOrOdd}");
                    break;

                case '*':
                    result = numberOne * numberTwo;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - {evenOrOdd}");
                    break;

                case '/':
                    result = (double)numberOne / (double)numberTwo;
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
                    break;

                case '%':
                    result = numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
                    break;




            }


          


        }
    }
}
