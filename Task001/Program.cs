// 1. Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
void PointIntersection(int k1, int b1, int k2, int b2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else if(k1==k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        int x = (b1-b2)/(k2-k1);
        int y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых - ({x},{y})");
    }
}
Console.WriteLine("Введите коэффициент k1 - ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент b1 - ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент k2 - ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент b2 - ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
PointIntersection(k1, b1, k2, b2);