// //  9.Показать последнюю цифру трёхзначного числа**

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
while (number<100 || number>999)
{
    Console.WriteLine("Введенное число не является треззначным, введите число снова");
    Console.WriteLine("Введите трехзначное число");
    number = int.Parse(Console.ReadLine()!);
}
Console.WriteLine($"Последняя цифра введенного числа {number%10} ");
