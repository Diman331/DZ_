/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()!);

int[] nums = new int[m];
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    nums[i] = int.Parse(Console.ReadLine()!);
}

int count = 0;
foreach (int num in nums)
{
    if (num > 0)
    {
        count++;
    }
}

Console.WriteLine("[" + string.Join(", ", nums) + "] -> " + count);