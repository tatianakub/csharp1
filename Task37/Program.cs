﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве
// [12345] -> 583

int[] CreateArrayRndInt(int size, int min, int max) // создаем метод, который создает массив и заполняет его псевдослучайными числами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int[] MultiplicationNumbers(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    
    return newArray;
}


int[] arr = CreateArrayRndInt(4, 1, 9);
PrintArray(arr);

int[] res = MultiplicationNumbers(arr);
PrintArray(res);
