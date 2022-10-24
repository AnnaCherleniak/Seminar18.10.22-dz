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
void ResizeImage(int[,]image, int k)
{
    
        
}

void FillImage(int x, int y)
{
    image[0,0] = 1;
}

int[,]image = new int[3,3];

//PrintImage(image);
//Console.WriteLine("Масштабирование - ");
image[0,0] = 1;
image[2,0] = 1;
image[2,2] = 1;
image[0,2] = 1;
Console.WriteLine();
//ResizeImage(0, 0, 4);
FillImage(0,0);
PrintImage(image);
