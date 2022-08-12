// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int n)
{
    if (n < 0)
        Console.WriteLine("Введено некорректное число, повторите попытку");
    else
    {
        Console.WriteLine("----------");
        Console.WriteLine(" n  | n^3 ");
        Console.WriteLine("----------");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i,3} | {Math.Pow(i, 3),4}");
        }
        Console.WriteLine("----------");
    }
}
Cube (num);

