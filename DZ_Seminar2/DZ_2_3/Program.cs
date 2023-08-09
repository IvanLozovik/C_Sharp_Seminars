// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным
System.Console.Write("Введите номер дня недели: ");
string dayNumber = Console.ReadLine();
int dayNum = int.Parse(dayNumber);
switch (dayNum)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("Нет. Не выходной.");
        break;
    case 6:
    case 7:
        System.Console.WriteLine("Да. Выходной!");
        break;
    default:
        System.Console.WriteLine("Неверный номер");
        break;
}
