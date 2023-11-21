internal class Program
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[]? loops;

    private static void Main()
    {
        //Console.Write("N = ");
        //numberOfLoops = int.Parse(Console.ReadLine());
        //Console.Write("K = ");
        //int k = int.Parse(Console.ReadLine());
        //numberOfIterations = k;

        //loops = new int[numberOfLoops];
        //NestedLoops(0);

        GetNumbers(5);


    }

    public static int GetNumbers(int n)
    {
        if (1 == n)
        {
            return 5;
        }

        return 5 * n + GetNumbers(n - 1);


    }




    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }


        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }


    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}