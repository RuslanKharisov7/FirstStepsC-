// 23. Показать таблицу квадратов чисел от 1 до N 


Console.WriteLine("Введите целое натуральное число");
double number = double.Parse(Console.ReadLine()!);
double M = 1;
while(M<=number)
{
    Console.Write($"{(Math.Pow(M,3))}, ");
    M++;
}