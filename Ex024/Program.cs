//25. Найти сумму чисел от 1 до А
Console.Clear();
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");
int GetSum (int A)
{
    int sum = 0;
    for (int i = 1; i<= A; i++)
    sum+=i;
    return sum;
}