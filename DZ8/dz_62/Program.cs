int n = 4;
int[,] array = new int[n, n];

int i = 0, j = 0, num = 1;
int min_i = 0, min_j = 0, max_i = n - 1, max_j = n - 1;

while (num <= n * n)
{
    // Движение вправо
    for (j = min_j; j <= max_j; j++)
    {
        array[i, j] = num;
        num++;
    }
    j--;
    i++;

    // Движение вниз
    for (i = min_i + 1; i <= max_i; i++)
    {
        array[i, j] = num;
        num++;
    }
    i--;
    j--;

    // Движение влево
    for (j = max_j - 1; j >= min_j; j--)
    {
        array[i, j] = num;
        num++;
    }
    j++;
    i--;

    // Движение вверх
    for (i = max_i - 1; i > min_i; i--)
    {
        array[i, j] = num;
        num++;
    }
    i++;
    j++;

    // Уменьшаем границы
    min_i++;
    min_j++;
    max_i--;
    max_j--;
}

// Выводим массив построчно
for (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]:00} ");
    }
    Console.WriteLine();
}