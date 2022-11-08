// 3. Написать программу масштабирования фигуры (0,0)(2,0)(2,2)(0,2)

int CountCoordinates(string text, char c)
{
    int count = 0;
    for(int i = 0; i < text.Length; i ++)
        if(text[i] == ',')
            count++;
    return count;
}
void ResizeFigure(int[] array, int k)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * k;
}
string text = "(0,0)(2,0)(2,2)(0,2)";
int length = CountCoordinates(text, ',');
int[] x = new int[length];
int[] y = new int[length];
int j = 0;
int k = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i] == '(')
    {       
        if(j < length)
        {
            var pointX = $"{text[i+1]}";
            int temp = int.Parse(pointX);
            x[j] = temp;
            j++;
        }
    }
    if(text[i] == ',')
    {
        if(k < length)
        {
            var pointX = $"{text[i+1]}";
            int temp = int.Parse(pointX);
            y[k] = temp;
            k++;
        }
    }
}
Console.WriteLine("Введите коэффициент масштабированик: ");
int n = int.Parse(Console.ReadLine() ?? "0");
ResizeFigure(x, n);
ResizeFigure(y, n);
for(int i = 0; i < x.Length; i++)
    Console.Write($"({x[i]},{y[i]}) ");
Console.WriteLine();

