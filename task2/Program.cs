﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----------");
Console.WriteLine(" n  | n^3 ");
Console.WriteLine("----------");

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"{i, 3} | {i*i*i, 4}");  
}
Console.WriteLine("----------");
