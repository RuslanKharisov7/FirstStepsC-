// 2.Даны два числа. Показать большее и меньшее число**

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ыторое число");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA>numberB)
{
    Console.WriteLine($"Большее число {numberA}, меньшее число {numberB}");
}
else
{
    Console.WriteLine($"Большее число {numberB}, меньшее число {numberA}");
}