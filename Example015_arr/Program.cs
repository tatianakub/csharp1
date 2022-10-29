﻿// Работаем с массивом, сортируем его от минимум к максимум

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)                //выводим массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
      Console.WriteLine($"{array[i]} ");  
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i; //код обмена двух переменных местами

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            { 
                minPosition = j;
            }       
        }
    
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
