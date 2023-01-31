// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.Clear();
Console.WriteLine("Введите число для проверки на кратность 7 и 23");
int number = int.Parse(Console.ReadLine()!);
if (number%7 == 0 && number%23 == 0)
{
    Console.WriteLine($"Да кратно");
}
else
{
    Console.WriteLine("Нет не кратно");
}