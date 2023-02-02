// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine()!);
if (number == 1)
{
    Console.WriteLine("Диапазон заданной четверти {x>0 && y>0}");
}
if (number == 2)
{
    Console.WriteLine("Диапазон заданной четверти {x<0 && y>0}");
}
if (number == 3)
{
    Console.WriteLine("Диапазон заданной четверти {x<0 && y<0}");
}
if (number == 4)
{
    Console.WriteLine("Диапазон заданной четверти {x>0 && y<0}");
}