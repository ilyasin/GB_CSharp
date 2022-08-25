/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Task21(Point a, Point b) {
    return Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y) + (b.Z - a.Z) * (b.Z - a.Z));
}

System.Console.WriteLine(Task21(new Point(3,6,8), new Point(2,1,-7)));
System.Console.WriteLine(Task21(new Point(7,-5,0), new Point(1,-1,9)));

public record Point
{
    public double X {  get; set; }
    public double Y {  get; set; }
    public double Z {  get; set; }
    
    public Point(double x, double y, double z) {
        this.X = x;
        this.Y = y;
        this.Z = z;
    } 
}