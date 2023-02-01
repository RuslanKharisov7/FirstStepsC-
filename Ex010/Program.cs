// 10.Показать вторую цифру трёхзначного числа**

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int rez = (number/10)%10;
Console.WriteLine($"Вторая цифра числа {number}, цифра {rez}");