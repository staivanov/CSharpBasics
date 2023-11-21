public class Program
{
    private static void Main()
    {
        string fileName = "text.txt";
        string text = GetTextFromFile(fileName);
        string originalWord = "start",
            wordToReplace = "finish";
        text = text.Replace(originalWord, wordToReplace);

        WriteTextToFile(fileName, text);

    }
    public static string GetTextFromFile(string path)
    {
        StreamReader reader = File.OpenText(path);
        string textOutput = reader.ReadToEnd();
        reader.Close();

        return textOutput;
    }


    public static void WriteTextToFile(string path, string text)
    {
        StreamWriter writer = File.CreateText(path);
        writer.WriteLine(text);
        writer.Close();
    }
}