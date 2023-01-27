// 0.Вывести квадрат числа**
using System.Globalization;
Console.WriteLine("Введите число которое желаете возвести в квадрат, дробные числа вводятся через запятую");
double? numberA=double.Parse(Console.ReadLine()!);
Console.WriteLine("Квадрат введенного числа :" + numberA * numberA);

