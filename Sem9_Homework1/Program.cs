// Показать натуральные числа от M до N, N и M заданы

void PosNumbers(int a, int b)
{
    if (a <= b)
    {
        Console.Write(a + " ");
        PosNumbers(a + 1, b);
    }
};
void NegNumbers(int a, int b)
{
    if (a >= b)
    {
        Console.Write(a + " ");
        NegNumbers(a - 1, b);
    }
};

Console.Write("Введите первое число диапазона: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число диапазона: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (m > n) NegNumbers(m, n);
else if (n > m) PosNumbers(m, n);