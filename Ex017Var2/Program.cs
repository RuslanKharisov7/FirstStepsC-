// 17. По двум заданным числам проверять является ли одно квадратом другого**
Console.Clear();
Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);
if (numberA*numberA == numberB)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
    return;
}
if (numberB*numberB == numberA)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
    Console.WriteLine("Не одно из чисел не является квадратом второго");
}