// 8.Показать четные числа от 1 до N

Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine()!);
double M = 1;
while (M<=number)
{
    if (M % 2 ==0)
    Console.Write($"{M} ");
    M++;
}