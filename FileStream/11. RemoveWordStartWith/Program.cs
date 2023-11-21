using System.Text.RegularExpressions;

internal class Program
{
    private static void Main()
    {
        //Pattern for matching words starting with "test" -->  (?=(test)).\w+
        string fileName = "text.txt";
        string textOutput = GetTextFromFile(fileName);
        string newText = RemoveWordsFromTextStartingWith(textOutput);
        Console.WriteLine(textOutput);
        Console.WriteLine();
        Console.WriteLine(newText);
    }

    public static string GetTextFromFile(string fileName)
    {
        StreamReader reader = File.OpenText(fileName);
        string textOutput = reader.ReadToEnd();
        reader.Close();

        return textOutput;
    }


    public static string RemoveWordsFromTextStartingWith(string text)
    {   //wordPrefix = "test"
        string pattern = "(?=(test)).\\w+";
        Regex regex = new Regex(pattern);
        MatchCollection matchedWords = regex.Matches(text);
        string newText = regex.Replace(text, "", matchedWords.Count);

        return newText;
    }
}