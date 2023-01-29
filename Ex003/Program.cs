// 3. По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);
if (number == 1)
{
    Console.WriteLine($"Введенный номер дня недели {number}");
    Console.WriteLine("Это Понедельник");
}
if (number == 2)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это вторник");
}
if (number == 3)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это среда");
}
if (number == 4)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это четверг");
}
if (number == 5)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это пятница");
}
if (number == 6)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это суббота");
}
if (number == 7)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Это воскресенье");
}
if (number > 7)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("В неделе только 7 дней");
}
if (number < 1)
{
    Console.WriteLine($"Введенное номер дня недели {number}");
    Console.WriteLine("Исчисление дней недели начинается с 1");
}