int number;
Console.Write("Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка: число не является пятизначным.");
    return;
}

int first = number / 10000;
int second = (number / 1000) % 10;
int fourth = (number / 10) % 10;
int fifth = number % 10;

if (first == fifth && second == fourth)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
