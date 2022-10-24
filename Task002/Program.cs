// 2. Показать числа Фибоначчи

double Fibonacci(int n)
{
    if(n == 1 || n == 2)
        return 1;
    else 
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
Console.WriteLine("До какого числа вывести таблицу чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine() ?? "0");
for(int i = 1; i <= N; i++)
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");