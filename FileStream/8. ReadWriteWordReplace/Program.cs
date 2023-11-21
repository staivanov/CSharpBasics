using System.Text.RegularExpressions;

internal class Program
{
    private static void Main()
    {
        string fileName = "text.txt";
        StreamReader reader = File.OpenText(fileName);

        using (reader)
        {
            string originalWord = "Lorem",
                  newWord = "Fresh",
                  pattern = $"(\\bLorem\\b)";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            string currentLine = reader.ReadLine();
            string text = currentLine.Replace(originalWord, newWord);

        }
    }
}