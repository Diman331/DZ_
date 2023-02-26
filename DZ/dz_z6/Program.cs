// --------Задание 6-------

int num;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num);
if(num % 2 == 0)
    Console.WriteLine("Чётное");
else
    Console.WriteLine("Не чётное");