int[,] matrix1 = ReadMatrixFromConsole("Введите первую матрицу:");
int[,] matrix2 = ReadMatrixFromConsole("Введите вторую матрицу:");

// Проверяем, можно ли умножить матрицы
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно умножить матрицы.");
    return;
}

// Определяем результирующую матрицу
int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// Умножаем матрицы
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Первая матрица:");
PrintMatrixToConsole(matrix1);

Console.WriteLine("Вторая матрица:");
PrintMatrixToConsole(matrix2);

// Выводим результат
Console.WriteLine("Результат произведения матриц:");
PrintMatrixToConsole(result);

static int[,] ReadMatrixFromConsole(string message)
{
    Console.WriteLine(message);

    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов: ");
    int cols = int.Parse(Console.ReadLine()!);

    int[,] matrix = new int[rows, cols];

    Console.WriteLine("Введите элементы матрицы:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"[{i}, {j}]: ");
            matrix[i, j] = int.Parse(Console.ReadLine()!);
        }
    }

    return matrix;
}

static void PrintMatrixToConsole(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}