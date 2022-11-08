// 3. Написать программу масштабирования фигуры (0,0)(2,0)(2,2)(0,2)
void CoordinatesX(string text, int[] array)
{
    string t = String.Empty;
    int j = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == '(')
        {
            i++;
            if(j < array.Length)
            {
                var point = t;
                while(text[i] != ',')
                {
                    point += $"{text[i]}";
                    i++;
                }
                int temp = int.Parse(point);
                array[j] = temp;
                j++;
            }
        }
    }
}
void CoordinatesY(string text, int[] array)
{
    string t = String.Empty;
    int j = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == ',')
        {
            i++;
            if(j < array.Length)
            {
                var point = t;
                while(text[i] != ')')
                {
                    point += $"{text[i]}";
                    i++;
                }
                int temp = int.Parse(point);
                array[j] = temp;
                j++;
            }
        }
    }
}
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
CoordinatesX(text, x);
CoordinatesY(text, y);
Console.WriteLine("Введите коэффициент масштабированик: ");
int k = int.Parse(Console.ReadLine() ?? "0");
ResizeFigure(x, k);
ResizeFigure(y, k);
for(int i = 0; i < x.Length; i++)
    Console.Write($"({x[i]},{y[i]}) ");
Console.WriteLine();

