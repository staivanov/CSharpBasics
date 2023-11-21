public class Program
{
    public static void Main()
    {
        long result = Sum(10);
    }


    public static long Sum(int n)
    {
        if (0 == n)
        {
            return 0;
        }
        else
        {
            return n + Sum(n - 1);
        }
    }
}