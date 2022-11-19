// Найти сумму элементов от M до N, N и M заданы

int AdditionNum(int a, int b)
{
    if (a == b) return b;
    return a + AdditionNum(a + 1, b);
};

Console.Write("Введите первое число диапазона: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите последнее число диапазона: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Сумма диапазона равна: ");

if (m > n) Console.WriteLine(AdditionNum(n, m));
else if (n > m) Console.WriteLine(AdditionNum(m, n));