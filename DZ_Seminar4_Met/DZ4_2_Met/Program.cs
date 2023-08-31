// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitsInNumber (int number)
{
    int result = 0;
    while (number>0)
    {
    result += number%10;
    number/=10; 
    }    
    return result;
}

System.Console.WriteLine($"{SumDigitsInNumber(12593)}");