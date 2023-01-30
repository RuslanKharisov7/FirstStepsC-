// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine($"Число {number}");
int num1 = number/10;
int num2 = number%10;
if (num1>num2)
{
    Console.WriteLine($"Наибольшая цифра числа {number}, цифра {num1}");
}
else 
{
    Console.WriteLine($"Наибольшая цифра числа {number}, цифра {num2}");
}