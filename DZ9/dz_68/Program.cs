Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("m = {0}, n = {1} -> A(m,n) = {2}", m, n, Ackermann(m, n));

static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}