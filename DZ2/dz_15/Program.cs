int day;
string[] nedela = { "null", "Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};
Console.Write("Введите номер дня недели от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out day);

if(day < 1 && day > 7)
    Console.WriteLine("Введен не верный номер");
else
    Console.WriteLine(nedela[day]);