internal class Program
{
    public static void Main()
    {
        int n = 4;
        int[] a = { 10, 8, 5, 9 };

        int result = LCM(a, n);

    }


    public static int GCD(int a, int b)
    {
        return (0 == b) ? a : GCD(b, a % b);
    }


    public static int LCM(int[] a, int n)

         
    {
        int b;

        if (2 == n)
        {
            return (a[0] * a[1]) / GCD(a[0], a[1]);
        }
        else
        {
            b = LCM(a, n - 1);
            return (a[n - 1] * b) / GCD(a[n - 1], b);
        }
    }
}