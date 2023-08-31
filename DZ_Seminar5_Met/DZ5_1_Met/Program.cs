// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetNumberDouble (int[] array)
{
    int result = 0;
    foreach (var item in array)    
    {
        if (item%2==0) result+=1;
    }
return result;
}

int [] GenerateMassive (int Len)
{
    int [] array = new int [Len];
    for (int i = 0; i < Len; i++)
    {
        array [i] = new Random().Next(100, 1000);
     
    }
    return array;
}

void PrintMassive (int[] array)
{
    Console.Write("[");
    foreach (var item in array) 
    {
     System.Console.Write($"{item} ");
    }
    Console.WriteLine ("]");
}

int [] Massive = GenerateMassive (10);
PrintMassive (Massive);
System.Console.WriteLine ($"{GetNumberDouble (Massive)}");