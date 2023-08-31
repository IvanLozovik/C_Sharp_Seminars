// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintMassive (int[] array)
{
    Console.Write("[");
    foreach (var item in array) 
    {
    //Console.WriteLine (array [i]);
    System.Console.Write($"{item}");
    }
    Console.WriteLine ("]");
}

int [] GetMassive (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(0, 10);
     
    }
    return array;
}

PrintMassive (GetMassive(8));

