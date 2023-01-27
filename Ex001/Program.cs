// 1.По двум заданным числам проверять является ли первое квадратом второго**

double numberA = new Random().Next(0, 10);
Console.WriteLine("Первое число: " + numberA);
double numberB = new Random().Next(0, 10);
Console.WriteLine("Второе число:" + numberB);
if (numberA/numberB == numberA)
{
    Console.WriteLine("Первое число является квадратом второго");
}
if (numberB == 0)
{
    Console.WriteLine("Деление на ноль не возможно");
}
if (numberA == 0)
{
    Console.WriteLine("При деление 0 на любое число, результат будет 0");
}
 else
 {
    Console.WriteLine("Первое число не является квадратом второго");
 }
