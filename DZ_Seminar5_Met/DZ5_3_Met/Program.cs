// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetMinElement (double[] array)
{
    double result = array [0];
    for (int i=1; i < array.Length; i++)    
    {
        if (array[i]<result) result = array [i];
    }
    return result;
}

double GetMaxElement (double[] array)
{
    double result = array [0];
    for (int i=1; i < array.Length; i++)    
    {
        if (array[i]>result) result = array [i];
    }
    return result;
}

double [] GenerateMassive (int Len)
{
    double [] array = new double [Len];
    for (int i = 0; i < Len; i++)
    {
        // array [i] = new Random().Next(-100, 100); //случайное целое число от -100 до 100
        array [i] = new Random().NextDouble() * 200 - 100; //случайное double число от -100 до 100
    }
    return array;
}

void PrintMassive (double[] array)
{
    Console.Write("[");
    foreach (var item in array) 
    {
     System.Console.Write($"{item} ");
    }
    Console.WriteLine ("]");
}

double [] Massive = GenerateMassive (8);
PrintMassive (Massive);
// System.Console.WriteLine ($"{GetMaxElement(Massive) - GetMinElement(Massive)}");
System.Console.WriteLine ($"{GetMaxElement(Massive)} - {GetMinElement(Massive)} = {GetMaxElement(Massive) - GetMinElement(Massive)}");