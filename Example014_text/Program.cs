﻿// Задача на работу с текстом. Дан текст. В тексте нужно все пробелы заменить черточками. Маленькие буквы "к" заменить на большие "К",
// а большие "С" заменить маленькими "с"

string  text = "- Я думаю, - сказал князь, улыбаясь, - что,"
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "abcde"
//             01234
// s[3] это буква d здесь

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;    // инециализация пустой строки
    int length = text.Length; //Посчитает все символы в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);