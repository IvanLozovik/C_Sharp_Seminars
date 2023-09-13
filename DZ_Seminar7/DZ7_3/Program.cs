// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, 
// PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] 
// и возвращает одномерный массив типа double. Этот метод вычисляет 
// среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
// и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, 
// разделенные знаком табуляции.

 void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    }
  
int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int znachenie = 1;
        for (int i = 0; i < n; i++)
        {   
            for (int j = 0; j < m; j++)
            {
            matrix[i, j] = znachenie;
            znachenie+=k;
            }
        }
        return matrix;
    }
  
void PrintListAvr (double [] list)
{
    // Введите свое решение ниже
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.GetLength(0); i++)
    {
        System.Console.Write($"{list[i]:f2}\t");
    }
}

double[] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
    double [] aver = new double[matrix.GetLength(1)];
 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum+=matrix[i, j];
        }
         aver[j]=sum/matrix.GetLength(0);
    }
    return aver;

    }
        
        int n = 3;
        int m = 4;
        int k = 2;
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
