int num;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

string? StrNum = num.ToString();
if(StrNum.Length >= 3)
    Console.WriteLine(StrNum[2]);
else
    Console.WriteLine("Нет третьей цифры");