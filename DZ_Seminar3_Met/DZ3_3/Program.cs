// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
ShowCube(25);
void ShowCube(int num)
{
   for (int i=1; i<=num; i++)
   {
    System.Console.WriteLine(i*i*i);
   }     
}