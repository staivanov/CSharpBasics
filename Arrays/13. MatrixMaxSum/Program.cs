int[,] matrixNumber =
{
  {0, 0, 1, 0, 3, 1, 1 },
  {1,0,0,0, 3, 2, 2 },
  {3, 1, 5, 1, 1,0 ,0 },
  {2, 4, 5, 4, 1, 2, 2 },
  {1, 1, 1, 1,1, 3, 3 },
  {2, 2, 2, 2, 2, -1, 4 },
  {3, 3, 3, 3, 3, -2, -1 }
};

int bestSum = 0,
    sum;

for (int col = 0; col < matrixNumber.GetLength(0) - 2; col++)
{
    for (int row = 0; row < matrixNumber.GetLength(1) - 2; row++)
    {
        sum = matrixNumber[col, row] + matrixNumber[col, row + 1] + matrixNumber[col, row + 2] +
            matrixNumber[col + 1, row] + matrixNumber[col + 1, row + 1] + matrixNumber[col + 1, row + 2] +
            matrixNumber[col + 2, row] + matrixNumber[col + 2, row + 1] + matrixNumber[col + 2, row + 1];

        if (bestSum < sum)
        {
            bestSum = sum;
        }
    }
}

Console.WriteLine(bestSum);
