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
string text = "(10,20)(12,20)(12,22)(10,22)";
int length = CountCoordinates(text, ',');
string t = String.Empty;
int[] x = new int[length];
int[] y = new int[length];
int j = 0;
int k = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i] == '(')
    {
        i++;
        if(j < length)
        {
            var point = t;
            while(text[i] != ',')
            {
                point += $"{text[i]}";
                i++;
            }
            int temp = int.Parse(point);
            x[j] = temp;
            j++;
        }
    }
    if(text[i] == ',')
    {
        i++;
        if(k < length)
        {
            var point = t;
            while(text[i] != ')')
            {
                point += $"{text[i]}";
                i++;
            }
            int temp = int.Parse(point);
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

