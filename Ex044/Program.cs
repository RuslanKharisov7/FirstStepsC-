//  44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы пользователем

Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);

if(k1-k2 == 0)
{
    Console.WriteLine("Решение не возможно т.к для вычисления координат точки х требуется деление на ноль");
} 
else
{
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"{x}, {y}");
}