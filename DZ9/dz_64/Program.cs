Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
PrintNumbers(n);

static void PrintNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }

    Console.Write(n + " ");
    PrintNumbers(n - 1);
}
