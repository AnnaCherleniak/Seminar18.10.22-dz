// 2. Показать числа Фибоначчи

//double Fibonacci(int n)
//{
  //  if(n == 1 || n == 2)
    //    return 1;
    //else 
        //return Fibonacci(n - 1) + Fibonacci(n - 2);
//}
Console.WriteLine("До какого числа вывести таблицу чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int f;
int f1 = 1;
int f2 = 1;

for(int i = 1; i <= N; i++)
{
    if(i <= 2)
        f = 1;
    else
    {
        f = f1 + f2;
        f2 = f1;
        f1 = f;
    }
    Console.WriteLine($"f({i}) = {f}");
}