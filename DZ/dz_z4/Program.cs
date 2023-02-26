//      --------Задание 4---------
int num1;
int num2;
int num3;

Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num2);
Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num3);

if(num1 > num2)
    if(num1 > num3)
    Console.WriteLine("max = {0}", num1);
    else
    Console.WriteLine("max = {0}", num3);
else
    if(num2 > num3)
    Console.WriteLine("max = {0}", num2);
    else
    Console.WriteLine("max = {0}", num3);