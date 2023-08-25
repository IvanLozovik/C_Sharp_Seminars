// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

int num = 53235;
System.Console.WriteLine(IsPalindrome(num));

bool IsPalindrome (int num)
{
    if (num/10000 < 0) 
    {
        System.Console.WriteLine("Число не пятизначное");
        return (false);
    }
        else
    {
        if (num/100000 > 0) 
        {
            System.Console.WriteLine("Число не пятизначное");
            return(false);
        }
    }
    
    if (num/10000!=num%10) return(false);
    else if ((num/1000)%10 != ((num%100)/10)) return(false);
    else return (true);
}