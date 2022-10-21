// Напимшите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 2D пространстве 
// А(3,6); B(2,1) -> 5,09

// double d = Math.Sqrt(45); вычисляет корень из числа 45
// double result = Math.Round(d, 2, MidpointRounding.ToZero); до какого знака можно округлить число результат
// Console.WriteLine()result;


Console.Write("Введите координату точки х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату точки х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int x21, int y21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    double rangeZ = Math.Sqrt(rangeX*rangeX + rangeY*rangeY);
    return rangeZ;
}
double result = Range(x1, y1, x2, y2);

Console.Write($"А ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
