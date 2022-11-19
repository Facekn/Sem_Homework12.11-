// Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

 void SumNumb(int a, int b, int n, int m)
{
    if (n <= m)
    {
        int sum = a + b;
        Console.Write($"{sum} ");
        SumNumb(b,sum,n+1,m);
        
    }
}

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во вывода: ");
int c = int.Parse(Console.ReadLine() ?? "0");
SumNumb(a, b, 1, c); 
