// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumNonDoubleIndex (int[] array)
{
    int result = 0;
    for (int i=0; i < array.Length; i++)    
    {
        if (i%2==1) result+= array [i];
    }
    return result;
}

int [] GenerateMassive (int Len)
{
    int [] array = new int [Len];
    for (int i = 0; i < Len; i++)
    {
        array [i] = new Random().Next(-100, 100);
     
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

int [] Massive = GenerateMassive (4);
PrintMassive (Massive);
System.Console.WriteLine ($"{GetSumNonDoubleIndex(Massive)}");
