/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a;
int b;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите степень: ");
int.TryParse(Console.ReadLine()!, out b);

int result = a;
int t = a;
for (int i = 1; i < b; i++)
{
    result = result * t;
}
Console.WriteLine($"Число {a} в степени {b} = {result}");
