public class Program
{
    public static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n, m);
        Console.WriteLine(sum);
    }


    public static int CalculateSum(int n, int m)
    {
        int sum = n;

        if (n < m)
        {
            n++; 
            return sum += CalculateSum(n, m);
        }
        return sum;
    }
}