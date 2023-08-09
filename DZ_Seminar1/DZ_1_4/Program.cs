// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
int number1 = new Random().Next( 1, 100 );
    Console.WriteLine("Число: " + number1);
for (int i=1; i<number1; i++) 
    {
       if ( i%2 == 0)
            {
            System.Console.Write(" " +i); 
            }
      
    }