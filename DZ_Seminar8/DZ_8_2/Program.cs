// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int [,] CreateRandomMatrix(int m, int n, int minLimitRandom=10, int maxLimitRandom=100)
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

int GetNumberMinRowSum (int[,] matrix) 
{   int rowMinSum = 2000000;
    int numberRowMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j=0; j<matrix.GetLength(1); j++)
            {
                rowSum+=matrix[i,j];
            } 

        if (rowSum < rowMinSum) 
            {
                rowMinSum = rowSum;
                numberRowMinSum = i+1;
            }
    }    
return numberRowMinSum;
}

int[,] result = CreateRandomMatrix(6, 10, 1, 10);
PrintArray(result);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов:{GetNumberMinRowSum(result)}");
