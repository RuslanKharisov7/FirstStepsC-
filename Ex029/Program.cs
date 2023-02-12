// 29. Написать программу вычисления произведения чисел от 1 до N**

Console.Clear();
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} = {ResNumber(N)}");

int ResNumber (int N)
{
   int result = 1;
        for(int i = 2; i<=N; i++)
        result*=i;
        return result;
}
