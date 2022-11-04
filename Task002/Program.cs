// 2. Показать числа Фибоначчи

int Fibonacci(int n)
{
    int f = 1;
    int f1 = 1;
    int f2 = 1;
    for(int i = 3; i <= n; i++)
    {
        f = f1 + f2;
        f2 = f1;
        f1 = f;
    }
    return f;
}

Console.WriteLine("До какого числа вывести таблицу чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine() ?? "0");
for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}