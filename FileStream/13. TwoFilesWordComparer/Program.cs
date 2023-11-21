public class Program
{
    private static char[] splittingSymbols = new char[] { ' ', ')', '(', '.', ',', '\'', };

    private static void Main()
    {
        string wordTextFile = "word.txt";
        string textFile = "text.txt";
        string wordOutput = GetTextFromFile(wordTextFile);
        string textOutput = GetTextFromFile(textFile);

        Dictionary<string, int> wordTextOccurrence = CountWordOccurrenceInText(wordOutput);
        Dictionary<string, int> textFileOccurrence = CountWordOccurrenceInText(textOutput);
        Dictionary<string, int> sameWordOccurrence = CountWordAndValueOccurrenceFromTwoDictionaries(wordTextOccurrence, textFileOccurrence);

        string resultFilePath = "result.txt";
        WriteToDestination(resultFilePath, sameWordOccurrence);
    }

    private static string GetTextFromFile(string filePath)
    {
        StreamReader reader = File.OpenText(filePath);
        string textOutput;

        using (reader)
        {
            textOutput = reader.ReadToEnd();
        }

        return textOutput;
    }


    private static string[] SplitText(string text)
    {
        string[] splittedText = text.Split(splittingSymbols,
            StringSplitOptions.RemoveEmptyEntries);

        return splittedText;
    }


    private static Dictionary<string, int> CountWordOccurrenceInText(string text)
    {
        Dictionary<string, int> wordOccurrence = new();
        string[] splitedText = SplitText(text);
        int index = 0,
            wordCount = 1;

        while (index < splitedText.Length)
        {
            if (wordOccurrence.ContainsKey(splitedText[index]))
            {
                wordOccurrence[splitedText[index]]++;
            }
            else
            {
                wordOccurrence.Add(splitedText[index], wordCount);
                wordCount = 1;
            }

            index++;
        }

        return wordOccurrence;
    }


    public static Dictionary<string, int> CountWordAndValueOccurrenceFromTwoDictionaries(Dictionary<string, int> firstDict,
        Dictionary<string, int> secondDict)
    {
        Dictionary<string, int> sameWords = new();

        foreach (var firstDictKeyValuePair in firstDict)
        {
            if (secondDict.ContainsKey(firstDictKeyValuePair.Key))
            {
                sameWords.Add(firstDictKeyValuePair.Key, firstDictKeyValuePair.Value);
            }
        }

        return sameWords;
    }


    public static void WriteToDestination(string filePath, Dictionary<string, int> wordAndValueOccurrence)
    {
        StreamWriter writer = File.CreateText(filePath);

        using (writer)
        {
            foreach (var kvPair in wordAndValueOccurrence)
            {
                writer.WriteLine(kvPair);
            }
        }
    }
}