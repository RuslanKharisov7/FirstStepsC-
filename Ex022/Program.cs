// 22. Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
Console.WriteLine("Введите координаты точки A");
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);
int za= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B");
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);
int zb = int.Parse(Console.ReadLine()!);
double dist = (Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2)));
Console.WriteLine($"Расстояние между заданными точками {dist}");

