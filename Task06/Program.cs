﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0) System.Console.WriteLine("Да");

else System.Console.WriteLine("Нет");