
// // // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // // Например, на выходе получается вот такой массив:
// // // 01 02 03 04
// // // 12 13 14 05
// // // 11 16 15 06
// // // 10 09 08 07

// // int[,] CreateSpiralMatrix(int n, int m, int beginNumber=1)
// //     {
// //         int[,] matrix = new int[n, m];
// //         int znachenie = beginNumber;
// //         for (int i = 0; i < n; i++)
// //         {   
// //             for (int j = 0; j < m; j++)
// //             {
// //             matrix[i, j] = znachenie;
// //             znachenie+=1;
// //             }
// //             for (int i = 0; i < n; i++)
// //         }
// //         return matrix;

// //     double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
// //     {
// //         // Введите свое решение ниже
// //         double[,] matrix = new double[m, n];
// //         Random r = new Random();
// //         for (int i = 0; i < m; i++)
// //         {   
// //             for (int j = 0; j < n; j++)
// //             {
// //             matrix[i, j] = r.NextDouble() * (maxLimitRandom - minLimitRandom)+minLimitRandom;

// //             }
// //         }
// //         return matrix;
// //     }

// // void PrintArray(double[,] matrix)
// // {
// //     // Введите свое решение ниже
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write($"{matrix[i, j]:f2} ");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }


// // double[,] result = CreateRandomMatrix(6, 7, -100, 300);
// // PrintArray(result);


// int n = 8; // Размерность массива
//         int[,] array = new int[n, n]; // Создание двумерного массива
        
//         int value = 1; // Начальное значение для заполнения массива
        
//         int row = 0; // Текущая строка
//         int col = 0; // Текущий столбец
//         int rowDir = 0; // Направление движения по строкам (0 - вправо, 1 - вниз, 2 - влево, 3 - вверх)
//         int colDir = 1; // Направление движения по столбцам (0 - вправо, 1 - вниз, 2 - влево, 3 - вверх)
        
//         // Заполнение массива
//         for (int i = 0; i < n * n; i++)
//         {
//             array[row, col] = value;
//             value++;
            
//             // Проверка следующей позиции
//             int nextRow = row + rowDir;
//             int nextCol = col + colDir;
            
//             if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n || array[nextRow, nextCol] != 0)
//             {
//                 // Изменение направления движения
//                 int temp = rowDir;
//                 rowDir = colDir;
//                 colDir = -temp;
//             }
            
//             // Обновление текущей позиции
//             row += rowDir;
//             col += colDir;
//         }
        
//         // Вывод массива на консоль
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }

 int n = 5; // Размерность массива
        int[,] array = new int[n, n]; // Создание двумерного массива
        
        int value = 1; // Начальное значение для заполнения массива
        
        int rowStart = 0; // Индекс начальной строки
        int rowEnd = n - 1; // Индекс конечной строки
        int colStart = 0; // Индекс начального столбца
        int colEnd = n - 1; // Индекс конечного столбца
        
        // Заполнение массива
        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Заполнение верхней строки
            for (int col = colStart; col <= colEnd; col++)
            {
                array[rowStart, col] = value;
                value++;
            }
            rowStart++;
            
            // Заполнение правого столбца
            for (int row = rowStart; row <= rowEnd; row++)
            {
                array[row, colEnd] = value;
                value++;
            }
            colEnd--;
            
            // Заполнение нижней строки
            if (rowStart <= rowEnd)
            {
                for (int col = colEnd; col >= colStart; col--)
                {
                    array[rowEnd, col] = value;
                    value++;
                }
                rowEnd--;
            }
            
            // Заполнение левого столбца
            if (colStart <= colEnd)
            {
                for (int row = rowEnd; row >= rowStart; row--)
                {
                    array[row, colStart] = value;
                    value++;
                }
                colStart++;
            }
        }
        
        // Вывод массива на консоль
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }