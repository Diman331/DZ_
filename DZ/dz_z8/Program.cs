// --------Задание 8--------

int n;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for(int i = 1; i <= n; i++)
    if(i % 2 == 0)
        Console.Write("{0}, ", i);
