// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int stepen = Convert.ToInt32(Console.ReadLine());
int sum = 1;


for (int i = 0; i < stepen; i++)
{
    sum = sum * x;
}

Console.WriteLine($"{x} в степени {stepen} = {sum}");