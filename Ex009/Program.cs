//  9.Показать последнюю цифру трёхзначного числа**
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 || number > 999)
{
    Console.WriteLine("Число не является трехзначным");
    return;
}
Console.WriteLine($"Последняя цифра числа {number} это цифра {number%10}");
