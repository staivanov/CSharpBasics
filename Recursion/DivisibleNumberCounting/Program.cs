internal class Program
{
    private static void Main(string[] args)
    {
        double n = 24;
        int counterNdivision = CountDivision(n);
        Console.WriteLine(counterNdivision);





    }

    public static int CountDivision(double number)
    {
        int count = 0;

        if (number > 0 && (number % 2 == 0))
        {
            count++;
            number /= 2;
            return count += CountDivision(number);
        }

        return count;
    }









}