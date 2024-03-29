﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*Решаем уравнение

k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают, точек пересечения бесконечно много");
    }
    else
    {
        Console.WriteLine("Прямые параллельны, точек пересечения нет");
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}