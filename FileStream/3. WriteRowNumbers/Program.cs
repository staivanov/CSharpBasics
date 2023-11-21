public class Program
{
    private static void Main()
    {
        string fileName = "text.txt";
        TextReader reader = new StreamReader(fileName);
        List<string> text = new List<string>();

        using (reader)
        {
            int lineCounter = 1;
            string line = reader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                text.Add($"{lineCounter}. {line}");
                line = reader.ReadLine();
                lineCounter++;
            }
        }

        TextWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            int textLength = text.Count;
            int index = 0;

            while (index < textLength)
            {
                writer.WriteLine(text[index]);
                index++;
            }
        }
    }
}