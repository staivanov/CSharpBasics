internal class Program
{
    public static void Main()
    {
        string fileName = "names.txt";
        string sortedFileNames = "sortedNames.txt";
        StreamReader reader = File.OpenText(fileName);
        string[] names;

        using (reader)
        {
            string currentLine = reader.ReadLine();
            names = currentLine.Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);
        }

        StreamWriter writer = new(sortedFileNames);

        using (writer)
        {
            string line = null;

            foreach (var name in names)
            {
                writer.WriteLine(name);
            }
        }

    }
}