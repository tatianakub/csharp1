// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] arr = CreateArray(4);
PrintArray(arr);



int[] CreateArray(int num)
{
    int[] array = new int[num]; 
     Random rnd = new Random(); 
     for (int i = 0; i < array.Length; i++) 
     { 
         array[i] = rnd.Next(100, 1000); 
     } 
     return array; 
}

void PrintArray(int[] array) 
 { 
     Console.Write("["); 
     for (int i = 0; i < array.Length; i++) 
     { 
         if (i < array.Length - 1) System.Console.Write($"{array[i]},"); 
         else Console.Write($"{array[i]}"); 
     } 
     Console.WriteLine("]"); 
 }

int Number(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    res++;
    return res;

}

int res1 = Number(arr);
Console.WriteLine($"{res1}");