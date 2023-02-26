// --------Задача 10--------

int num;

Console.Write("Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out num);

Console.WriteLine((num/10) % 10);