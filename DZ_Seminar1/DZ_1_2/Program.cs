//  Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
int number1 = new Random().Next( 1, 1000 );
Console.WriteLine("Первое число: " + number1);
int number2 = new Random().Next( 1, 1000 );
Console.WriteLine("Второе число: " + number2);
int number3 = new Random().Next( 1, 1000 );
Console.WriteLine("Третье число: " + number3);
int Maximum = number1;
if ( number2 > Maximum )
    {
    Maximum = number2;
    }
    if ( number3 > Maximum )
        {
        Maximum = number3;
        }
System.Console.WriteLine("Максимальное число = " + Maximum);