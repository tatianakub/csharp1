// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = CreateArray(4);
PrintArray(arr);

int[] CreateArray(int num)
{
    int[] array = new int[num]; 
     Random rnd = new Random(); 
     for (int i = 0; i < array.Length; i++) 
     { 
         array[i] = rnd.Next(10, 100); 
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
    if (i % 2 != 0) res = res + array[i];
    return res;

}

int res1 = Number(arr);
Console.WriteLine($"{res1}");