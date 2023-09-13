// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetMultiMatrix (int [,] matrixA, int [,] matrixB)
{
    int [,] matrixC = new int [,] { matrixA.GetLength (0) };
}

int [,] CreateRandomMatrix(int m=2, int n=2, int minLimitRandom=1, int maxLimitRandom=10)
    {
        int[,] matrix = new int[m, n];
        Random r = new Random();
        for (int i = 0; i < m; i++)
        {   
            for (int j = 0; j < n; j++)
            {
            matrix[i, j] = r.Next(minLimitRandom, maxLimitRandom);
            }
        }
        return matrix;
    }

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
