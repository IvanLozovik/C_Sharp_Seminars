// Напишите программу, которая 
// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    int number1 = new Random().Next( 100, 1000 );
    Console.WriteLine("Число: " + number1);
    Console.WriteLine((number1/10)%10); 
    

