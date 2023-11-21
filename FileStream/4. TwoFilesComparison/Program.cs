internal class Program
{
    private static void Main(string[] args)
    {
        string fileName = "textOne.txt";
        string fileNameTwo = "textTwo.txt";

        TextReader reader = new StreamReader(fileName);
        TextReader readerTwo = new StreamReader(fileNameTwo);

        using (reader)
        using (readerTwo)
        {
            string line = reader.ReadLine();
            string lineSecondReader = readerTwo.ReadLine();

            int sameLineOccurrence = 0,
                differentLine = 0;

            while (!string.IsNullOrEmpty(line))
            {
                if(line == lineSecondReader)
                {
                    sameLineOccurrence++;
                }
                else
                {
                    differentLine++;
                }

                line = reader.ReadLine();
                lineSecondReader = readerTwo.ReadLine();
            }

            Console.WriteLine(sameLineOccurrence);
            Console.WriteLine(differentLine);
        }
    }
}