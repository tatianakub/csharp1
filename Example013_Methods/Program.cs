// 4 группы методов есть 
// 1 вид: ничего не возвращают и ничего не принимают
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
Method1();

// 2 вид: методы, которые ничего не возвращают, но могут принимать какие-то аргументы
//void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

//3 вид: методы, которые что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4 вид: методы, которые что-то принимают и что-то возвращают

//string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty;

//    while (i < count)
//    {
//       result = result + text;
//       i++;
//    }
//    return result;
// }
//либо с циклом фор, он всё собирает в себе, к примеру:
//for(int i =0; i<10; i++) 
//Console.WriteLine(i);

string Method4(int count, string text)
{
   string result = String.Empty;
   for(int i = 0; i < count; i++)
   {
      result = result + text;   
   }
   return result;
}
string res = Method4(10, "abc");
//Console.WriteLine(res);



//Задача вывести таблицу умножения способом цикл в цикле:

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{j}*{i} = {i*j}");
    }
    Console.WriteLine();
}


