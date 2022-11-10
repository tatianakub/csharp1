// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number) //метод
{
    int sum = default; // дефолт показывает, что значение не определено
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum; //возвращаем результат метода
}

int sumNumbers = SumNumbers(num); //создаем переменную и вызываем наш метод

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");