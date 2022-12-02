// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число а: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число b: ");
int numB = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return AkkermanFunction(a - 1, 1);
    return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}
if (numA >= 0 && numB >= 0)
{
    int res = AkkermanFunction(numA, numB);
    Console.WriteLine($"Значение функции Аккермана({numA},{numB}) = {res}");
}
else
{
    Console.WriteLine("Вы ввели неверные данные");
}
