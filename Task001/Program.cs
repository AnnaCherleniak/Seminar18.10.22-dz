// 1. Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void PointIntersection(float[] point, float k1, float b1, float k2, float b2)
{
    point[0] = (b1 - b2)/(k2 - k1);
    point[1] = k2 * ((b1 - b2)/(k2 - k1)) + b2;
}
void PrintArray(float[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.WriteLine("Введите коэффициент k1 - ");
float k1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент b1 - ");
float b1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент k2 - ");
float k2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите коэффициент b2 - ");
float b2 = float.Parse(Console.ReadLine() ?? "0");
if(k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else if(k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        float[] point = new float[2];
        PointIntersection(point, k1, b1, k2, b2);
        PrintArray(point);
    }