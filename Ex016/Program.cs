﻿// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.Clear();
Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine()!);
if (day == 1)
{
    Console.WriteLine($"Введенное число {day} это понедельник, понедельник не является выходным");
}
if (day == 2)
{
    Console.WriteLine($"Введенное число {day} это вторник, вторник не является выходным");
}
if (day == 3)
{
    Console.WriteLine($"Введенное число {day} это среда, среда не является выходным");
}
if (day == 4)
{
    Console.WriteLine($"Введенное число {day} это четверг, четверг не является выходным");
}
if (day == 5)
{
    Console.WriteLine($"Введенное число {day} это пятница, пятница не является выходным");
}
if (day == 6)
{
    Console.WriteLine($"Введенное число {day} это суббота, суббота это выходной день");
}
if (day == 7)
{
    Console.WriteLine($"Введенное число {day} это воскресенье, воскресенье это выходной день");
}
if (day < 1)
{
    Console.WriteLine("Исчисление дней недели начинается с 1");
}
if (day > 7)
{
    Console.WriteLine("В неделе только 7 дней");
}
