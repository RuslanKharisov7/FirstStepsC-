// 6.Выяснить является ли число чётным
Console.WriteLine("Введите число для проверки на четность");
int number = int.Parse(Console.ReadLine()!);
if (number%2 == 0)
{
    Console.WriteLine("Введенное число является четным");
}
else 
{
    Console.WriteLine("Число не является четным ");
}