internal class Program
{
    public static void Main()
    {
        string textOne = "textOne.txt",
            textTwo = "textTwo.txt",
            textThree = "textThree.txt";

        StreamReader readerOne = new StreamReader(textOne);
        StreamReader readerTwo = new StreamReader(textTwo);
        StreamWriter writer = new StreamWriter(textThree);

        using (readerOne)
        using (readerTwo)
        using (writer)
        {
            string readedTextOne = readerOne.ReadToEnd();
            string readedTextTwo = readerTwo.ReadToEnd();

            writer.WriteLine(readedTextOne);
            writer.WriteLine(readedTextTwo);
        }
    }
}