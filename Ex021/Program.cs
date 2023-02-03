// 21. Программа проверяет пятизначное число на палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число от 10000 до 99999");
int number = int.Parse(Console.ReadLine()!);
int a = number/10000;
int b = (number/1000)%10;
int c = (number/100)%10;
int d = (number/10)%10;
int e = number%10;

if (a+b == d+e)
{
  Console.WriteLine($"Введенное число {number}, является палиндромом");
}
 else 
 {
    Console.WriteLine($"Число {number}, не является палиндромом");
 }


