// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummMtoN (int m, int n)
{ 
    int summ=m;
    if (m < n) summ+= SummMtoN(m+1, n);
    return summ;
}
System.Console.WriteLine(SummMtoN (4,8));