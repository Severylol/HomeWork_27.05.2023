Console.Clear();
Console.Write("Координату A(1): ");
double a1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату B(1): ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату C(1): ");
double c1 = double.Parse(Console.ReadLine()!);
Console.Write("Координату A(2): ");
double a2 = double.Parse(Console.ReadLine()!);
Console.Write("Координату B(2): ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Координату C(2): ");
double c2 = double.Parse(Console.ReadLine()!);
double S = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b2 - b1, 2) + Math.Pow (c1 +c2, 2)); //допустим S -расстоние, нам надо взять квадратный корень Math.Sqrt вещественный кв.корень далее Math.Pow возведение в степень
Console.WriteLine($"Расстояние равно {Math.Round(S, 3)}");