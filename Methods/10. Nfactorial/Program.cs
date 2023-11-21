using System;

namespace Nfactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int myFactorial = GetNumberFactorial(n);
            Console.WriteLine(myFactorial);
        }

        public static int GetNumberFactorial(int n)
        {
            bool isValidN = (n >= 0) && (n <= 100);

            if (isValidN)
            {
                int factorial = n;
                factorial = n == 0 ? 1 : factorial;

                while (n > 1)
                {
                    factorial *= (n - 1);
                    n--;
                }

                return factorial;
            }
            else
            {
                return -1;
            }
        }
    }
}
