// 3. Написать программу масштабирования фигуры (0,0)(2,0)(2,2)(0,2)

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string text = "(10,0)(12,0)(12,2)(10,2)";
string points = Replase(text, '(', ' ');
points = Replase(points, ')', ' ');
points = Replase(points, ',', ' ');
Console.WriteLine(points);
var pointX = $"{points[1]}" + $"{points[2]}";
int x = int.Parse(pointX);
Console.WriteLine(pointX);
Console.WriteLine(x);







//Console.WriteLine("Введите коэффициент масштабированик: ");
//int k = int.Parse(Console.ReadLine() ?? "0");
