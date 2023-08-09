// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
    Console.Write("Введите число: ");
    string numStr1 = Console.ReadLine();
    int number1 = int.Parse(numStr1);
    //int number1 = new Random().Next( 0, 1000000000);   
    // Console.WriteLine("Исходное число: " + number1);
    if (number1/100==0)
    {
        Console.WriteLine("Третьей цифры нет!");
        return;
    }
    while (number1/1000 > 0)  
    {
        number1=number1/10;
    }  
Console.WriteLine("Третья цифра = " + number1 % 10);