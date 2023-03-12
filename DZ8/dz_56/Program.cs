Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в массиве: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, cols]; // создаем пустой массив указанного размера

// заполняем массив вручную
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"Введите элемент массива [{i},{j}]: ");
        array[i, j] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nИсходный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

// находим строку с наименьшей суммой элементов
int minRowIndex = 0;
int minRowSum = int.MaxValue;
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minRowSum)
    {
        minRowIndex = i;
        minRowSum = rowSum;
    }
}

// выводим результат
Console.WriteLine("Строка с наименьшей суммой элементов: " + (minRowIndex + 1));