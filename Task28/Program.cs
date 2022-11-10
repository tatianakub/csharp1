﻿// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
{
    int multiply = 1;
    for (int i = 1; i <= number; i++)
    {
        multiply *=i;
    }
    return multiply;
}

int factorial = Factorial(num);

Console.WriteLine($"Произведение чисел от 1 до {num} = {factorial}");