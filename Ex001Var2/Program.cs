// 1.По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);
if (numberA/numberB == numberB)
{
    Console.WriteLine("Введенное число является квадратом второго");
}
 else
 {
    Console.WriteLine("Первое число не является квадратом второго");
 }
if (numberA == 0)
{
    Console.WriteLine("При деление 0 на любое число ответ будет 0");
}
 if (numberB == 0)
 {
    Console.WriteLine("Деление на 0 не возможно");
 }
