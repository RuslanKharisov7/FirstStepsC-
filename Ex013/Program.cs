// 13.Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();
Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine()!);
int rez = numberA%numberB;
if (numberA%numberB == 0)
{
    Console.WriteLine($"Первое число {numberA}, кратно второму числу {numberB}");
}
else
{
    Console.WriteLine($"Первое число {numberA}, не кратно второму числу {numberB} остаток от деления равен {rez}");
}