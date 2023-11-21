namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            //PrintMatrixA(matrix);
            PrintMatrixB(matrix);
        }

        public static void PrintMatrixA(int[,] squareMatrix)
        {
            int squareLength = squareMatrix.Length;
            int counter = 1,
                sum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    Console.Write($"{squareMatrix[row, col] = counter + sum}  ");
                    sum += 4;
                }

                counter++;
                sum = 0;
                Console.WriteLine();
            }
        }


        public static void PrintMatrixB(int[,] squareMatrixB)
        {
            int counter = 0,
                sum = 0;

            for (int row = 0; row < squareMatrixB.GetLength(0); row++)
            {
                counter++;
                sum = 0;

                for (int col = 0; col < squareMatrixB.GetLength(1); col++)
                {
                    if(col % 2 == 0)
                    {
                        Console.Write($"{counter + sum} ");
                        
                    }
                    else
                    {
                        sum += squareMatrixB.GetLength(1) * 2 - row;
                        Console.Write($"{sum} ");
                        sum += row;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
