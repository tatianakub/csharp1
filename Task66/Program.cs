//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите первое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numM = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n, int m)
{
    if (n == m) return n;
    if (n < m) return m + SumNumbers(n, m - 1);
    return m + SumNumbers(n, m + 1);

}

int res = 0;

if (numN < 0)
{
int newN = 1;
res = SumNumbers(newN, numM);
Console.WriteLine($"Сумма от {numM} до {numN} = {res}");
}
if (numM < 0)
{
int newM = 1;
res = SumNumbers(numN, newM);
Console.WriteLine($"Сумма от {numM} до {numN} = {res}");
}
else if (numM >0 && numN >0)
{
res = SumNumbers(numN, numM);
Console.WriteLine($"Сумма от {numM} до {numN} = {res}");
}
