public class Program
{
    public static void Main()
    {
        int a = 10,
            b = 15,
            gcd;

        gcd = GetGCDRecursive(a, b);
        Console.WriteLine(gcd);
    }


    public static int Euclidean(int a, int b)
    {
        while (true)
        {
            if (a > b)
            {
                a -= b;
            }
            else if (a == b)
            {
                return a;
            }
            else
            {
                b -= a;
            }
        }
    }


    public static int GetGCDIterative(int a, int b)
    {
        int swap;

        while (b > 0)
        {
            swap = b;
            b = a % b;
            a = swap;
        }

        return a;
    }


    public static int GetGCDRecursive(int a, int b)
    {
        return (0 == b) ? a : GetGCDRecursive(b, a % b);
    }
}