int n;
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.WriteLine($"Таблица кубов чисел от 1 до {n}:");
for (int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.WriteLine(i + "^3 = " + cube);
}