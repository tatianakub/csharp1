﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
string number3 = Convert.ToString(number);
if (number3.Length > 2){
  Console.WriteLine("Третья цифра " + number3[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}