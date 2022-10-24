// 4. Написать программу копирования массива

void FillArray(int[]array, int min, int max)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}");
    Console.WriteLine();
}
void CopyArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j < array.Length; j++)
            {
                if(j == i)
                    array[j] = array[i];
            }
    }
}
void PrintCopyArray(int[]array)
{
    for(int j = 0; j < array.Length; j++)
        Console.Write($"{array[j]}");
    Console.WriteLine();
}


Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]array = new int[length];
FillArray(array, 1, 10);
Console.WriteLine("Ваш массив: ");
PrintArray(array);
CopyArray(array);
Console.WriteLine("Копия массива: ");
PrintCopyArray(array);