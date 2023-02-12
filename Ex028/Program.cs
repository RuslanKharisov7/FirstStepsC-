// 28. Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите целое натуральное число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} = {GetSum(number)}");

    int GetSum (int A)
{
    int result = 0;
    while (number>0)
    {
        result += number%10;
        number = number/10;
    }
    return result;
}
