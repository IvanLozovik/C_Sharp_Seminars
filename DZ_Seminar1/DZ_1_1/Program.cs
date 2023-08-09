// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
int number1 = new Random().Next( 1, 100 );
Console.WriteLine("Первое число: " + number1);
int number2 = new Random().Next( 1, 100 );
Console.WriteLine("Второе число: " + number2);
if ( number1 != number2 )
    {
    Console.WriteLine(number1 > number2 ? "Первое число больше" : "Второе число больше");
    return;
    }
System.Console.WriteLine("Числа равны");