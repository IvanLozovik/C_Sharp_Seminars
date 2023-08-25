// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек 
// pointA и pointB в виде массива целых чисел, 
// и возвращает расстояние между ними в 3D пространстве.
System.Console.WriteLine(DistanceBetweenPoints(10,-8,0,-30,3,4));

double DistanceBetweenPoints (int ax, int ay, int az, int bx, int by, int bz)
{
    double distance = Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
    return distance;
}