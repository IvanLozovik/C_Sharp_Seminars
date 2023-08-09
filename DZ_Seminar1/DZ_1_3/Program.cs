// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
for (int i=0; i<20; i++) 
{
    int number1 = new Random().Next( -101, 100 );
    Console.Write("Число: " + number1);

        if ( number1%2 == 0)
            {
            System.Console.WriteLine(" - четное "); 
            }
        else 
        {
            System.Console.WriteLine(" - нечетное ");
        } 
}