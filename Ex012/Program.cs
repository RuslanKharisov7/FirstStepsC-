// 12.Удалить вторую цифру трёхзначного числа
Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Число {number}");
int num1 = number/100;
int num2 = (number/10)%10;
int num3 = number%10;
Console.WriteLine($"{num1}{num3}");
