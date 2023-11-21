using static System.Console;

string userText = ReadLine();

int[] userIndexes = GetCharsIndexByUserText(userText);

foreach (var index in userIndexes)
{
    Console.WriteLine(index);
}


static int[] GetCharsIndexByUserText(string userText)
{
    if (string.IsNullOrEmpty(userText)) return new int[1] { -1 };


    char[] alphabet = { 'a', 'b', 'c', 'd', 'e',
    'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
    'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
    'v', 'w', 'x', 'y', 'z' };

    string lowerCaseUserText = userText.ToLower();

    int[] characterIndexes = new int[userText.Length];

    for (int i = 0; i < userText.Length; i++)
    {
        for (int j = 0; j < alphabet.Length; j++)
        {
            if (lowerCaseUserText[i] == alphabet[j])
            {
                characterIndexes[i] = j;
            }
        }
    }

    return characterIndexes;
}