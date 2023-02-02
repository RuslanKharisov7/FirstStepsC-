// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
Console.WriteLine("Введите координаты X");
double x =double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y");
double y = double.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
{
    Console.WriteLine("Первая плоскость");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая плоскость");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Третья плоскость");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая плоскость");
}