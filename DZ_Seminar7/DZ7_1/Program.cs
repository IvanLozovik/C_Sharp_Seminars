// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix, 
// который принимал бы числа m и n (размеренность массива), 
// а также minLimitRandom и maxLimitRandom, которые указывают 
// на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.


    
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
