// 3. Написать программу масштабирования фигуры (0,0)(2,0)(2,2)(0,2)



Console.WriteLine("Введите координаты вершин фигуры списком: ");
string point =  String.Empty;
point = Convert.ToString(Console.ReadLine() ?? "0");
//int[] x = new int[4];
//int[] y = new int[4];
int x1 = Convert.ToInt32(point[6]);
//PrintArray(point);
Console.WriteLine(x1);



//Console.WriteLine("Введите коэффициент масштабированик: ");
//int k = int.Parse(Console.ReadLine() ?? "0");
///ResizeFigure(x1, y1, x2, y2, x3, y3, x4, y4, k);