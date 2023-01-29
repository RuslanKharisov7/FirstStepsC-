// 7.Показать числа от -N до N
Console.Clear();
Console.WriteLine("Введите число");
double N = int.Parse(Console.ReadLine()!);
double M = -N;
while (M<=N)
{
    Console.Write($"{M} ");
    M++;
}

