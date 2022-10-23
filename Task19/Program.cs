// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите целое пятизначное число ");
string number = Convert.ToString(Console.ReadLine()); 

//char[] arr = number.ToString().ToCharArray(); //задали массив

static bool IsPalindrome(string number)
{
    for (int i = 0; i < number.Length / 2; ++i)
        if (number[i] != number[number.Length - 1 - i]) return false;
    return true;
}

if (IsPalindrome(number) = true)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
