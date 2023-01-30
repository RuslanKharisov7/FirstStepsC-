// // 12.Удалить вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int result = (number/100)*10 + number%10;
Console.WriteLine(result);
