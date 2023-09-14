// // // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // // Например, на выходе получается вот такой массив:
// // // 01 02 03 04
// // // 12 13 14 05
// // // 11 16 15 06
// // // 10 09 08 07


        void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int [,] CreateSpiralMatrix (int m=4, int n=4, int beginNumber=1)
{
        int [,] spiralmatrix = new int[m, n];
        int rowStart = 0; 
        int rowEnd = m - 1;
        int colStart = 0;
        int colEnd = n - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int col = colStart; col <= colEnd; col++)
            {
                spiralmatrix[rowStart, col] = beginNumber;
                beginNumber++;
            }
            rowStart++;

            for (int row = rowStart; row <= rowEnd; row++)
            {
                spiralmatrix[row, colEnd] = beginNumber;
                beginNumber++;
            }
            colEnd--;

            if (rowStart <= rowEnd)
            {
                for (int col = colEnd; col >= colStart; col--)
                {
                    spiralmatrix[rowEnd, col] = beginNumber;
                    beginNumber++;
                }
                rowEnd--;
            }
            
            if (colStart <= colEnd)
            {
                for (int row = rowEnd; row >= rowStart; row--)
                {
                    spiralmatrix[row, colStart] = beginNumber;
                    beginNumber++;
                }
                colStart++;
            }
        }
    return spiralmatrix;
}

int [,] spiralArray = CreateSpiralMatrix ();
PrintArray (spiralArray);