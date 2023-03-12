
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = m; i <= n; i++)
    sum += i;

Console.WriteLine("M = {0}; N = {1} -> {2}", m, n, sum);