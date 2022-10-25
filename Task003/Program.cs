// 3. Написать программу масштабирования фигуры
void ResizeFigure(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int k)
{
    x1 *= k;
    y1 *= k;
    x2 *= k;
    y2 *= k;
    x3 *= k;
    y3 *= k;
    x4 *= k;
    y4 *= k;
    Console.WriteLine($"При k = {k} получаем координаты ({x1},{y1})({x2},{y2})({x3},{y3})({x4},{y4})");
}

int x1 = 0;
int y1 = 0;
int x2 = 2;
int y2 = 0;
int x3 = 2;
int y3 = 2;
int x4 = 0;
int y4 = 2;
Console.WriteLine("Введите коэффициент масштабированик: ");
int k = int.Parse(Console.ReadLine() ?? "0");
ResizeFigure(x1, y1, x2, y2, x3, y3, x4, y4, k);