// 4. Написать программу копирования массива

void FillArray(int[]array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
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
                if(j == i)
                    array[j] = array[i];

    }
    PrintArray(array);
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
Console.WriteLine("Копия массива: ");
CopyArray(array);