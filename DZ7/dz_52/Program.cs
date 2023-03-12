Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] arr = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write("Введите значение для [{0}, {1}]: ", i + 1, j + 1);
        arr[i, j] = int.Parse(Console.ReadLine()!);
    }
}

for (int j = 0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += arr[i, j];
    }
    double average = (double)sum / rows;
    Console.WriteLine("Среднее арифметическое для столбца {0}: {1:F2}", j + 1, average);
}
