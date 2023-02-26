// ---------Задача 2----------
int num1;
int num2;
Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write("Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out num2);
if(num1 > num2)
    Console.WriteLine("max = {0}", num1);
else
    Console.WriteLine("max = {0}", num2);
