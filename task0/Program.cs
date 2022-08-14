// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome5(int num)
{
    if (num > 9999 && num <= 99999)
    {
        int temp1 = num / 1000;
        int temp2 = num % 100;

        if (temp1 / 10 == temp2 % 10 && temp1 % 10 == temp2 / 10)
            Console.WriteLine($"Число {num} - палиндром");
        else
            Console.WriteLine($"Число {num} - не палиндром");
    }
    else
        Console.WriteLine($"Число {num} не пятизначное, попробуйте еще раз");
}

Palindrome5(number);