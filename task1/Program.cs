﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А: ");
Console.Write("Введите x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("Введите x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double distance = Math.Round(Math.Sqrt((xc1 - xc2) * (xc1 - xc2) + (yc1-yc2) * (yc1-yc2) + (zc1-zc2)*(zc1-zc2)),2,MidpointRounding.ToZero);
    return distance;
}

Console.WriteLine($"Расстояние между точками А ({x1},{y1}, {z1}) и B ({x2},{y2}, {z2} -> {Distance(x1,y1,z1,x2,y2,z2)}");