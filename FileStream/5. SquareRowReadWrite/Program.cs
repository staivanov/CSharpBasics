internal class Program
{
    private static void Main(string[] args)
    {
        string fileName = "matrix.txt";
        string outputFileName = "biggestSquareRow.txt";
        StreamReader reader = File.OpenText(fileName);

        using (reader)
        {
            string currentLine = reader.ReadLine();
            int number = Convert.ToInt32(currentLine);
            int[,] matrix = new int[number, number];
            int row = 0,
                 col = 0;

            currentLine = reader.ReadLine();

            while (currentLine != null)
            {
                string[] textNumbers = currentLine.Split(" ");

                while (col < matrix.GetLength(0))
                {
                    matrix[row, col] = Convert.ToInt32(textNumbers[col]);
                    col++;
                }

                col = 0;
                row++;
                currentLine = reader.ReadLine();
            }

            int bestSubmatrixSum = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                {
                    int subMatrixSum = matrix[i, j] + matrix[i, j + 1] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1];
                    bestSubmatrixSum = subMatrixSum > bestSubmatrixSum ? subMatrixSum : bestSubmatrixSum;
                }
            }

            StreamWriter writer = new StreamWriter(outputFileName);
            writer.Write(bestSubmatrixSum);
            writer.Close();
        }

    }
}