﻿// Напишите программу , которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (х и у)

Console.WriteLine("Введите номер четверти плоскости ");
string quarter = Console.ReadLine();

string Quarter(string quarterXY)
{
    if(quarterXY == "1") return "x > 0 и y > 0";
    if(quarterXY == "2") return "x < 0 и y > 0";
    if(quarterXY == "3") return "x < 0 и y < 0";
    if(quarterXY == "4") return "x > 0 и y < 0";
    return "Некорректный ввод";
}

 string xy = Quarter(quarter);
Console.Write($"Диапазон координат для четверти {quarter}: "); 
Console.WriteLine(xy);