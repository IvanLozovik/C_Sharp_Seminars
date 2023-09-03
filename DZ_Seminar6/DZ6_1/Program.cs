// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumbersMoreZero (int[] array)
{
int count = 0;
for (int i=0; i < array.Length; i++)
    {
        if (array [i] > 0) 
        {
        count+=1;
        }
    }
return count;
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

int [] Massive = GenerateMassive (10);
PrintMassive (Massive);
System.Console.WriteLine ($"{GetNumbersMoreZero(Massive)}");

