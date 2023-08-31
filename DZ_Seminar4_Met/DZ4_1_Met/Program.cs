// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumStepen (int num, int stepen)
{
    int result=1;
    
    while (stepen > 0) 
    { 
    result *= num; 
    stepen--;
    //System.Console.WriteLine(result); 
    }
return result;
}
// int res = GetNumStepen (3,5);   
// System.Console.WriteLine(res);
System.Console.WriteLine($"{GetNumStepen (2,4)}");