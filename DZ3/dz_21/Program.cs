Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
double x1 = double.Parse(Console.ReadLine()!);

Console.Write("y1 = ");
double y1 = double.Parse(Console.ReadLine()!);

Console.Write("z1 = ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
double x2 = double.Parse(Console.ReadLine()!);

Console.Write("y2 = ");
double y2 = double.Parse(Console.ReadLine()!);

Console.Write("z2 = ");
double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance:F2}");
