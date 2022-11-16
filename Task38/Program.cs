// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным эелементами массива
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// int[] CreateArrayRndInt(int size, int min, int max) 
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

double[] CreateArrayDouble(int size, int min, int max) 
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; // NextDouble генерирует числа от 0 до 1, именно диапазон для вещественных чисел
        array[i] = Math.Round(num, 1);     //округление
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

double[] arr = CreateArrayDouble(5, 10, 100);

PrintArray(arr);

 double imin = 0;
 double imax = 0;
    
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > arr[imax])
            imax = i;
        if (arr[i] < arr[imin])
            imin = i;
    }
    Console.WriteLine("min : array[" + imin + "] = " + arr[imin]);
    Console.WriteLine("max : array[" + imax + "] = " + arr[imax]);