using System.Text.RegularExpressions;

internal class Program
{
    //Pattern (?<=(>))\D.(?=(<))|(?<=\b)\w+(?=(<))
    private static void Main()
    {
        string fileName = "text.txt";
        string textOutput = GetXmlTextFromFile(fileName);
        List<string> words = GetAllWordsWithoutXmlTags(textOutput);
    }


    public static string GetXmlTextFromFile(string fileName)
    {
        StreamReader reader = File.OpenText(fileName);
        string outputText = reader.ReadToEnd();
        reader.Close();

        return outputText;
    }


    public static List<string> GetAllWordsWithoutXmlTags(string text)
    {
        List<string> capturedWords = new();
        string pattern = "(?<=(>))\\D.(?=(<))|(?<=\\b)\\w+(?=(<))";
        Regex regex = new(pattern);
        MatchCollection matchedWords = regex.Matches(text);
        int index = 0;

        while(index < matchedWords.Count)
        {
            capturedWords.Add(matchedWords[index].Value);
            index++;
        }

        return capturedWords;
    }
}