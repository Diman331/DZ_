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

// сортируем каждую строку массива в порядке убывания
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, j])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("\nОтсортированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
