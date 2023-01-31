// 17. По двум заданным числам проверять является ли одно квадратом другого**
Console.Clear();
Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);
if (numberA % numberB == 0 || numberB % numberA == 0)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Не одно из чисел не является квадрвтом другого");
}