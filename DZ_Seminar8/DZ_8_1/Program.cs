// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int [,] SortArrayRows (int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        for (int s=0; s<matrix.GetLength(1)-1; s++)
        {
            for (int j=s+1; j<matrix.GetLength(1); j++)
            {
                if (matrix[i,s]<matrix[i,j])
                {
                    temp=matrix[i,s];
                    matrix[i,s]=matrix[i,j];
                    matrix[i,j]=temp;
                }    
            }
        }
    }    
return matrix;
}

int[,] result = CreateRandomMatrix(5, 10);
PrintArray(result);
SortArrayRows (result);
System.Console.WriteLine("Отсортированный по убыванию массив :");
PrintArray(result);