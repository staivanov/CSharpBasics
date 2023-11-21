internal class Program
{
    private static void Main()
    {
        int n = 3;
        int k = 2;

        //SetN(1);
       
    }

    public static void SetN(int input)
    {
        if (4 == input)
            return;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"{i} {input}");
            SetN(input + 1);

        }
    }

    public static void SetNIterative(int n, int k)
    {
        int index = 1;

        while(index <= n)
        {


            index++;
        }



    }



}