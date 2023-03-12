int rows, cols;

Console.Write("Введите количество строк: ");
rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
cols = int.Parse(Console.ReadLine()!);

int[,] arr = new int[rows, cols];

Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write("arr[{0},{1}] = ", i, j);
        arr[i, j] = int.Parse(Console.ReadLine()!);
    }
}

int row, col;

Console.Write("Введите номер строки: ");
row = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца: ");
col = int.Parse(Console.ReadLine()!);

if (row < rows && col < cols)
{
    Console.WriteLine("Значение элемента: " + arr[row, col]);
}
else
{
    Console.WriteLine("Элемент не найден");
}