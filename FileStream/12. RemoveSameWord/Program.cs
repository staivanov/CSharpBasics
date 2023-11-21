using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string fileName = "words.txt";
        List<string> bannedWords = GetAllWordsFromFile(fileName);
        string textFileName = "text.txt";
        string text = GetTextFromFile(textFileName);
        StringBuilder textWithoutBannedWords = RemoveWordsFromText(text, bannedWords);
    }


    public static List<string> GetAllWordsFromFile(string fileName)
    {
        TextReader reader = File.OpenText(fileName);
        List<string> words = new();


        using (reader)
        {
            string currentLine = reader.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                words.Add(currentLine);
                currentLine = reader.ReadLine();
            }
        }
        return words;
    }


    public static string GetTextFromFile(string fileNameText)
    {
        TextReader reader = File.OpenText(fileNameText);
        string textOutput = reader.ReadToEnd();
        reader.Close();

        return textOutput;
    }


    public static StringBuilder RemoveWordsFromText(string text, List<string> bannedWords)
    {
        StringBuilder sb = new();
        sb.AppendLine(text);
        int index = 0;

        while (index < bannedWords.Count)
        {
            sb.Replace(bannedWords[index], "");
            index++;
        }

        return sb;
    }
}