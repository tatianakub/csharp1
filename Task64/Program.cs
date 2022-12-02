﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 
// N = 5 -> "5, 4, 3, 2, 1"  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void NatNumbers(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ; ");
        NatNumbers(n - 1);
    }
}

NatNumbers(num);
