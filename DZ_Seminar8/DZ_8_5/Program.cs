
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int n, int m, int beginNumber=1)
    {
        int[,] matrix = new int[n, m];
        int znachenie = beginNumber;
        for (int i = 0; i < n; i++)
        {   
            for (int j = 0; j < m; j++)
            {
            matrix[i, j] = znachenie;
            znachenie+=1;
            }
            for (int i = 0; i < n; i++)
        }
        return matrix;

    double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
    {
        // Введите свое решение ниже
        double[,] matrix = new double[m, n];
        Random r = new Random();
        for (int i = 0; i < m; i++)
        {   
            for (int j = 0; j < n; j++)
            {
            matrix[i, j] = r.NextDouble() * (maxLimitRandom - minLimitRandom)+minLimitRandom;

            }
        }
        return matrix;
    }

void PrintArray(double[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2} ");
        }
        System.Console.WriteLine();
    }
}


double[,] result = CreateRandomMatrix(6, 7, -100, 300);
PrintArray(result);