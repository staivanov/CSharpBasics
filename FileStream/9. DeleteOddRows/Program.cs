using System.Text;

internal class Program
{
    private static void Main()
    {
        string fileName = "text.txt";
        StringBuilder evenRowText = RemoveOddRowFromText(fileName);
        WriteTextTo(fileName, evenRowText);
    }
    

    public static StringBuilder RemoveOddRowFromText(string fileName)
    {
        int rowCounter = 1;
        StreamReader reader = File.OpenText(fileName);
        StringBuilder sb = new();

        using (reader)
        {
            string currentLine = reader.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                bool isRowEven = rowCounter % 2 == 0;

                if (isRowEven)
                {
                    sb.Append(currentLine);
                }

                rowCounter++;
                currentLine = reader.ReadLine();
            }
        }

        return sb;
    }


    public static void WriteTextTo(string fileName, StringBuilder sb)
    {
        StreamWriter writer = new StreamWriter(fileName);
        writer.WriteLine(sb);
        writer.Close();
    }
}