public class Program
{
    public static void Main()
    {
        string fileName = "text.txt",
            line;
        TextReader reader = new StreamReader(fileName);
        int counter = 1;

        using (reader)
        {
            line = reader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                if ((counter % 2) != 0)
                {
                    Console.WriteLine(line);
                }

                counter++;
                line = reader.ReadLine();
            }
        }
    }
}