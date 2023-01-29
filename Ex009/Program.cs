//  9.Показать последнюю цифру трёхзначного числа**
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последняя цифра числа {number} это цифра {number%10}");
