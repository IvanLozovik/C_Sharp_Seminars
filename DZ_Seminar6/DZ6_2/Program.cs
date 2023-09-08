// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] GetTwoLinesCrossPoint (double b1, double k1, double b2, double k2)
{

    double CrossPointX = (b1-b2)/(k2-k1);
    double CrossPointY = k1*CrossPointX +b1;
    double [] CrossPoint = {CrossPointX, CrossPointY};
    return CrossPoint ; 
}
double[] coord = GetTwoLinesCrossPoint(2,5,4,9);
System.Console.WriteLine    ($"{coord[0]}, {coord [1]}");
