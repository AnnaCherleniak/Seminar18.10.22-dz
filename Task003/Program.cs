// 3. Написать программу масштабирования фигуры

void PrintImage(int[,]image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0)
                Console.Write($" ");
            else
                Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FormImage(int[,]image, int k)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
          i = i * k;
          j = j * k;
        }
    }
}
int[,]image = new int[,]
{
    {1, 0, 1, 0},
    {0, 0, 0, 0},
    {1, 0, 1, 0},
    {0, 0, 0, 0},
};
PrintImage(image);
Console.WriteLine("Масштабирование - ");
FormImage(image, 2);
PrintImage(image);