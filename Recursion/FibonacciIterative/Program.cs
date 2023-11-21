public class Program
{
    public static void Main()
    {
        ulong result = FibonacciIterative(10);
    }


    public static ulong FibonacciIterative(int n)
    {
        ulong f1 = 0,
            f2 = 1;

        while (0 < n)
        {
            f2 = f1 + f2;
            f1 = f2 - f1;   
            n--;
        }

        return f1;
    }
}