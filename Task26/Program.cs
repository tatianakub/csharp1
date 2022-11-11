// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    numDigit = Math.Abs(numDigit); //переводит введенное число в положительное, если ввели отрицательное
    int count = 0;
    while (numDigit > 0)
    {
        numDigit = numDigit / 10;
        count++;
    }
    return count > 0 ? count : 1; //если ввели число 0
}
int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");
